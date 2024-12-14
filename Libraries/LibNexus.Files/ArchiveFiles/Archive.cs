using LibNexus.Core;
using LibNexus.Core.Extensions;
using LibNexus.Files.PackFiles;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LibNexus.Files.ArchiveFiles;

public class Archive : IDisposable
{
	private readonly Stream _stream;
	private readonly Pack _pack;
	private readonly ArchiveHeader _header;

	private readonly Collection<ArchiveEntry> _entries = [];

	private ulong FilesOffset => _pack.Locate(_header.FilesPage);

	private Archive(Stream stream, Pack pack)
	{
		_stream = stream;
		_pack = pack;

		_stream.Position = (long)_pack.Locate(_pack.RootPage);
		_header = new ArchiveHeader(_stream);

		_stream.Position = (long)FilesOffset;

		for (var i = 0U; i < _header.Files; i++)
		{
			var entry = new ArchiveEntry(_stream, () => FilesOffset, i);

			_entries.Add(entry.Page == 0 ? null : entry);
		}
	}

	public static async Task<Archive> Create(Stream stream)
	{
		var pack = await Pack.Create(stream);
		pack.Update(pack.RootPage, ArchiveHeader.Stride);

		stream.Position = (long)pack.Locate(pack.RootPage);
		var header = ArchiveHeader.Create(stream);

		header.FilesPage = (uint)pack.Add(0);

		stream.Position = 0;

		return await Read(stream, new Progress(), CancellationToken.None);
	}

	public static async Task<Archive> Read(Stream stream, Progress progress, CancellationToken cancellationToken)
	{
		progress.Title = "Reading archive";
		progress.Total = 2;

		var packProgress = new Progress();
		progress.Children.Add(packProgress);
		var pack = await Pack.Read(stream, packProgress, cancellationToken);
		progress.Children.Remove(packProgress);

		progress.Completed++;

		var archive = new Archive(stream, pack);

		progress.Completed++;

		return archive;
	}

	public void Store(byte[] data)
	{
		var hash = Hash.Create(data);
		var entry = _entries.FirstOrDefault(entry => entry != null && entry.Hash == hash);

		if (entry != null)
			return;

		var index = _entries.IndexOf(null);

		if (index == -1)
		{
			index = (int)_header.Files;

			_header.Files++;
			_pack.Update(_header.FilesPage, _header.Files * ArchiveEntry.Stride);
		}

		_stream.Position = (long)(_pack.Locate(_header.FilesPage) + (ulong)(index * ArchiveEntry.Stride));
		_entries.Add(entry = ArchiveEntry.Create(_stream, () => FilesOffset, (uint)index));

		var page = _pack.Add((ulong)data.Length);

		entry.Page = (uint)page;
		entry.Hash = hash;
		entry.Length = (ulong)data.Length;

		_stream.Position = (long)_pack.Locate(page);
		_stream.Write(data);
	}

	public byte[] Read(Hash hash)
	{
		var entry = _entries.FirstOrDefault(entry => entry != null && entry.Hash == hash);

		if (entry == null)
			return null;

		var offset = _pack.Locate(entry.Page);

		if (offset == 0)
			return null;

		_stream.Position = (long)offset;

		return _stream.ReadBytes(entry.Length);
	}

	public void Delete(Hash hash)
	{
		for (var i = 0; i < _entries.Count; i++)
		{
			var entry = _entries[i];

			if (entry == null || entry.Hash != hash)
				continue;

			_pack.Delete(entry.Page);

			_entries[i] = null;

			break;
		}
	}

	public bool Validate(Hash hash)
	{
		var data = Read(hash);

		return data != null && hash.Validate(data);
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);

		_pack.Dispose();
		_stream.Dispose();
	}
}
