using LibNexus.Core;
using LibNexus.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LibNexus.Files.PackFiles;

public class Pack : IDisposable
{
	private const string Magic = "PACK";
	private const uint Version = 1;
	private const ulong MegaByte = 1024 * 1024;

	private readonly Stream _stream;

	private readonly PackHeader _header;
	private readonly Dictionary<ulong, PackPhysicalPage> _physicalPages = [];
	private readonly Collection<PackVirtualPage> _virtualPages = [];

	private PackPhysicalPage VirtualPagesPhysicalPage => _physicalPages[_header.VirtualPagesOffset];
	public ulong RootPage => _header.RootPage;

	public ulong VirtualPages => (ulong)_virtualPages.LongCount(static virtualPage => virtualPage.PhysicalPage != null);

	private Pack(Stream stream)
	{
		_stream = stream;

		var magic = _stream.ReadWord();
		var version = _stream.ReadUInt32();

		if (magic != Magic)
			throw new Exception("Pack: Invalid magic");

		if (version != Version)
			throw new Exception("Pack: Invalid version");

		_header = new PackHeader(_stream);
	}

	public static async Task<Pack> Create(Stream stream)
	{
		if (stream.Position != 0)
			throw new ConstraintException("Pack: Invalid stream position");

		if (stream.Length != 0)
			throw new ConstraintException("Pack: Stream not empty");

		stream.WriteWord(Magic);
		stream.WriteUInt32(Version);

		var header = PackHeader.Create(stream);
		var rootPhysicalPage = CreatePhysicalPages(stream, header);
		var rootVirtualPage = CreateVirtualPages(stream, header);

		rootVirtualPage.Offset = rootPhysicalPage.Position;
		header.RootPage = rootVirtualPage.Index;

		stream.Position = 0;

		return await Read(stream, new Progress(), CancellationToken.None);
	}

	public static async Task<Pack> Read(Stream stream, Progress progress, CancellationToken cancellationToken)
	{
		progress.Title = "Reading pack";
		progress.Total = 2;

		var pack = new Pack(stream);

		var physicalProgress = new Progress();
		progress.Children.Add(physicalProgress);
		await pack.ReadPhysicalPages(physicalProgress, cancellationToken);
		progress.Children.Remove(physicalProgress);

		progress.Completed++;

		var virtualProgress = new Progress();
		progress.Children.Add(virtualProgress);
		await pack.ReadVirtualPages(virtualProgress, cancellationToken);
		progress.Children.Remove(virtualProgress);

		progress.Completed++;

		return pack;
	}

	private static PackPhysicalPage CreatePhysicalPages(Stream stream, PackHeader header)
	{
		var virtualPagesPhysicalPage = PackPhysicalPage.Create(stream, PackVirtualPage.Stride * 2);
		header.Length += PackPhysicalPage.Stride + virtualPagesPhysicalPage.Length;

		var rootPhysicalPage = PackPhysicalPage.Create(stream, 0);
		header.Length += PackPhysicalPage.Stride + rootPhysicalPage.Length;

		header.VirtualPagesOffset = virtualPagesPhysicalPage.Position;
		header.VirtualPages = 2;

		return rootPhysicalPage;
	}

	private async Task ReadPhysicalPages(Progress progress, CancellationToken cancellationToken)
	{
		progress.Title = "Reading physical pages";
		progress.Total = _header.Length / MegaByte;

		PackPhysicalPage lastPage = null;

		while (_stream.Position < (long)_header.Length)
		{
			cancellationToken.ThrowIfCancellationRequested();

			var physicalPage = new PackPhysicalPage(_stream) { Last = lastPage };

			if (physicalPage.Last != null)
				physicalPage.Last.Next = physicalPage;

			_physicalPages.Add(physicalPage.Position, physicalPage);

			lastPage = physicalPage;

			progress.Completed = (ulong)_stream.Position / MegaByte;
		}

		await Task.CompletedTask;
	}

	private static PackVirtualPage CreateVirtualPages(Stream stream, PackHeader header)
	{
		stream.Position = (long)header.VirtualPagesOffset;
		PackVirtualPage.Create(stream, header, 0);

		return PackVirtualPage.Create(stream, header, 1);
	}

	private async Task ReadVirtualPages(Progress progress, CancellationToken cancellationToken)
	{
		progress.Title = "Reading virtual pages";
		progress.Total = _header.VirtualPages;

		_stream.Position = (long)VirtualPagesPhysicalPage.Position;

		for (var i = 0UL; i < _header.VirtualPages; i++)
		{
			cancellationToken.ThrowIfCancellationRequested();

			var virtualPage = new PackVirtualPage(_stream, _header, i);
			var physicalPage = _physicalPages.GetValueOrDefault(virtualPage.Offset);

			if (physicalPage != null)
			{
				physicalPage.VirtualPages.Add(virtualPage);
				virtualPage.PhysicalPage = physicalPage;
			}

			_virtualPages.Add(virtualPage);

			progress.Completed++;
		}

		await Task.CompletedTask;
	}

	public ulong Add(ulong length)
	{
		var virtualPage = AllocateVirtualPage();
		var physicalPage = AllocatePhysicalPage(length);

		virtualPage.Offset = physicalPage.Position;
		virtualPage.Length = length;
		virtualPage.PhysicalPage = physicalPage;

		physicalPage.VirtualPages.Add(virtualPage);

		return virtualPage.Index;
	}

	public ulong Locate(ulong page)
	{
		if (page >= _header.VirtualPages)
			return 0;

		var virtualPage = _virtualPages[(int)page];

		return virtualPage.Offset;
	}

	public void Update(ulong page, ulong length)
	{
		if (page >= _header.VirtualPages)
			return;

		var virtualPage = _virtualPages[(int)page];
		var physicalPage = virtualPage.PhysicalPage;

		if (physicalPage == null)
		{
			physicalPage = AllocatePhysicalPage(length);

			virtualPage.Offset = physicalPage.Position;
			virtualPage.Length = length;
			virtualPage.PhysicalPage = physicalPage;

			physicalPage.VirtualPages.Add(virtualPage);
		}
		else
		{
			ResizePhysicalPage(physicalPage, length);

			virtualPage.Length = length;
		}
	}

	public void Delete(ulong page)
	{
		if (page >= _header.VirtualPages)
			return;

		var virtualPage = _virtualPages[(int)page];
		var physicalPage = virtualPage.PhysicalPage;

		if (physicalPage == null)
			return;

		virtualPage.Offset = 0;
		virtualPage.Length = 0;
		virtualPage.PhysicalPage = null;

		physicalPage.VirtualPages.Remove(virtualPage);

		if (physicalPage.VirtualPages.Count == 0)
			DeletePhysicalPage(physicalPage);
	}

	private PackVirtualPage AllocateVirtualPage()
	{
		for (var i = 1; i < (int)_header.VirtualPages; i++)
		{
			var virtualPage = _virtualPages[i];

			if (virtualPage.PhysicalPage == null)
				return virtualPage;
		}

		var length = (_header.VirtualPages + 1) * PackVirtualPage.Stride;

		if (VirtualPagesPhysicalPage.Length < length)
		{
			var newVirtualPagesPhysicalPage = ResizePhysicalPage(VirtualPagesPhysicalPage, length);
			_header.VirtualPagesOffset = newVirtualPagesPhysicalPage.Position;
		}

		_stream.Position = (long)VirtualPagesPhysicalPage.Position + (long)(_header.VirtualPages * PackVirtualPage.Stride);
		var newVirtualPage = new PackVirtualPage(_stream, _header, _header.VirtualPages);
		_virtualPages.Add(newVirtualPage);

		_header.VirtualPages++;

		return newVirtualPage;
	}

	private PackPhysicalPage AllocatePhysicalPage(ulong length)
	{
		var physicalPage = _physicalPages.Values.FirstOrDefault(
			physicalPage => physicalPage != VirtualPagesPhysicalPage && physicalPage.VirtualPages.Count == 0
				&& (physicalPage.Length >= length || physicalPage.Next == null)
		);

		if (physicalPage != null)
			return ResizePhysicalPage(physicalPage, length);

		_stream.Position = (long)_header.Length;

		var newPhysicalPage = PackPhysicalPage.Create(_stream, length);

		newPhysicalPage.Last = _physicalPages[_physicalPages.Keys.Max()];

		if (newPhysicalPage.Last != null)
			newPhysicalPage.Last.Next = newPhysicalPage;

		_physicalPages.Add(newPhysicalPage.Position, newPhysicalPage);

		_header.Length += length + PackPhysicalPage.Stride;

		return newPhysicalPage;
	}

	private PackPhysicalPage ResizePhysicalPage(PackPhysicalPage physicalPage, ulong length)
	{
		MergeLast(physicalPage);
		MergeNext(physicalPage);

		if (physicalPage.Length > length + PackPhysicalPage.Stride)
		{
			var remaining = physicalPage.Length - length - PackPhysicalPage.Stride;

			physicalPage.Length -= remaining + PackPhysicalPage.Stride;

			_stream.Position = (long)(physicalPage.Position + physicalPage.Length + PackPhysicalPage.Stride / 2);

			var remainingPhysicalPage = PackPhysicalPage.Create(_stream, remaining);
			remainingPhysicalPage.Last = physicalPage;
			remainingPhysicalPage.Next = physicalPage.Next;

			if (physicalPage.Next != null)
				physicalPage.Next.Last = remainingPhysicalPage;

			physicalPage.Next = remainingPhysicalPage;

			_physicalPages.Add(remainingPhysicalPage.Position, remainingPhysicalPage);

			return physicalPage;
		}

		if (physicalPage.Length >= length)
			return physicalPage;

		if (physicalPage.Next == null)
		{
			var missing = length - physicalPage.Length;

			_header.Length += missing;
			physicalPage.Length += missing;

			return physicalPage;
		}

		_stream.Position = (long)physicalPage.Position;
		var data = _stream.ReadBytes(physicalPage.Length);

		_stream.Position = (long)physicalPage.Position;
		_stream.WriteBytes(new byte[physicalPage.Length]);

		var newPhysicalPage = AllocatePhysicalPage(length);

		_stream.Position = (long)newPhysicalPage.Position;
		_stream.WriteBytes(data);

		foreach (var virtualPage in physicalPage.VirtualPages)
		{
			virtualPage.Offset = newPhysicalPage.Position;
			virtualPage.PhysicalPage = newPhysicalPage;
			newPhysicalPage.VirtualPages.Add(virtualPage);
		}

		physicalPage.VirtualPages.Clear();

		return newPhysicalPage;
	}

	private void DeletePhysicalPage(PackPhysicalPage physicalPage)
	{
		_stream.Position = (long)physicalPage.Position;
		_stream.WriteBytes(new byte[physicalPage.Length]);

		MergeLast(physicalPage);
		MergeNext(physicalPage);

		if (physicalPage.Next != null)
			return;

		_physicalPages.Remove(physicalPage.Position);
		_header.Length = physicalPage.Position - PackPhysicalPage.Stride / 2;
	}

	private void MergeLast(PackPhysicalPage physicalPage)
	{
		if (physicalPage.Last is not { VirtualPages.Count: 0 } || physicalPage.Last == VirtualPagesPhysicalPage)
			return;

		var remove = physicalPage.Last;
		var grow = remove.Length;

		remove.Length = 0;
		_physicalPages.Remove(remove.Position);

		physicalPage.Last = remove.Last;

		if (remove.Last != null)
			remove.Last.Next = physicalPage;

		_physicalPages.Remove(physicalPage.Position);

		physicalPage.Position -= grow + PackPhysicalPage.Stride;
		physicalPage.Length += grow + PackPhysicalPage.Stride;

		_physicalPages.Add(physicalPage.Position, physicalPage);
	}

	private void MergeNext(PackPhysicalPage physicalPage)
	{
		if (physicalPage.Next is not { VirtualPages.Count: 0 } || physicalPage.Next == VirtualPagesPhysicalPage)
			return;

		var remove = physicalPage.Next;
		var grow = remove.Length;

		remove.Length = 0;
		_physicalPages.Remove(remove.Position);

		physicalPage.Next = remove.Next;

		if (physicalPage.Next != null)
			physicalPage.Next.Last = physicalPage;

		physicalPage.Length += grow + PackPhysicalPage.Stride;
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);

		_stream.Dispose();
	}
}
