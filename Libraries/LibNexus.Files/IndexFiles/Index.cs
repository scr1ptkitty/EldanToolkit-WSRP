using LibNexus.Core;
using LibNexus.Files.PackFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LibNexus.Files.IndexFiles;

public class Index : IDisposable
{
	private readonly Stream _stream;
	private readonly Pack _pack;
	private readonly IndexHeader _header;

	private readonly Dictionary<uint, IndexDirectory> _directories = [];
	private readonly Dictionary<Hash, uint> _fileReferences = [];

	private Index(Stream stream, Pack pack)
	{
		_stream = stream;
		_pack = pack;

		_stream.Position = (long)_pack.Locate(_pack.RootPage);
		_header = new IndexHeader(_stream);
	}

	public static async Task<Index> Create(Stream stream)
	{
		var pack = await Pack.Create(stream);
		pack.Update(pack.RootPage, IndexHeader.Stride);

		stream.Position = (long)pack.Locate(pack.RootPage);
		var header = IndexHeader.Create(stream);

		var rootDirectoryPage = pack.Add(IndexDirectory.Stride);
		stream.Position = (long)pack.Locate(rootDirectoryPage);
		_ = IndexDirectory.Create(stream);

		header.Page = (uint)rootDirectoryPage;

		stream.Position = 0;

		return await Read(stream, new Progress(), CancellationToken.None);
	}

	public static async Task<Index> Read(Stream stream, Progress progress, CancellationToken cancellationToken)
	{
		progress.Title = "Reading index";
		progress.Total = 2;

		var packProgress = new Progress();
		progress.Children.Add(packProgress);
		var pack = await Pack.Read(stream, packProgress, cancellationToken);
		progress.Children.Remove(packProgress);

		progress.Completed++;

		var index = new Index(stream, pack);

		var directoriesProgress = new Progress();
		progress.Children.Add(directoriesProgress);
		await index.ReadDirectories(directoriesProgress, cancellationToken);
		progress.Children.Remove(directoriesProgress);

		progress.Completed++;

		return index;
	}

	private async Task ReadDirectories(Progress progress, CancellationToken cancellationToken)
	{
		progress.Title = "Reading directories";
		progress.Total = _pack.VirtualPages;

		await ReadDirectory(_header.Page, progress, cancellationToken);
	}

	public void CreateDirectory(string path)
	{
		var currentPage = FindDirectory(path, out var remaining);

		_ = remaining.Aggregate(currentPage, CreateDirectory);
	}

	public IEnumerable<string> ListDirectories(string path)
	{
		var page = FindDirectory(path, out var remaining);

		return remaining.Length > 0 ? [] : _directories[page].Directories.Keys.ToArray();
	}

	public IEnumerable<string> ListFiles(string path)
	{
		var page = FindDirectory(path, out var remaining);

		return remaining.Length > 0 ? [] : _directories[page].Files.Keys.ToArray();
	}

	public void DeleteDirectory(string path)
	{
		var lastSeparator = path.LastIndexOf('/');

		var remaining = Array.Empty<string>();

		var page = lastSeparator == -1 ? _header.Page : FindDirectory(path[..lastSeparator], out remaining);
		var name = lastSeparator == -1 ? path : path[(lastSeparator + 1)..];

		if (remaining.Length > 0)
			return;

		var parentDirectory = _directories[page];

		if (!parentDirectory.Directories.TryGetValue(name, out var childPage))
			return;

		var childDirectory = _directories[childPage];

		if (childDirectory.Directories.Count > 0 || childDirectory.Files.Count > 0)
			return;

		parentDirectory.Directories.Remove(name);

		WriteDirectory(page);

		_pack.Delete(childPage);
	}

	public void Rename(string oldPath, string newPath)
	{
		var oldLastSeparator = oldPath.LastIndexOf('/');
		var newLastSeparator = newPath.LastIndexOf('/');

		var oldRemaining = Array.Empty<string>();
		var newRemaining = Array.Empty<string>();

		var oldPage = oldLastSeparator == -1 ? _header.Page : FindDirectory(oldPath[..oldLastSeparator], out oldRemaining);
		var newPage = newLastSeparator == -1 ? _header.Page : FindDirectory(newPath[..newLastSeparator], out newRemaining);

		var oldName = oldLastSeparator == -1 ? oldPath : oldPath[(oldLastSeparator + 1)..];
		var newName = newLastSeparator == -1 ? newPath : newPath[(newLastSeparator + 1)..];

		if (oldRemaining.Length > 0)
			return;

		newPage = newRemaining.Aggregate(newPage, CreateDirectory);

		var oldDirectory = _directories[oldPage];
		var newDirectory = _directories[newPage];

		if (newDirectory.Directories.ContainsKey(newName) || newDirectory.Files.ContainsKey(newName))
			return;

		if (oldDirectory.Directories.Remove(oldName, out var page))
			newDirectory.Directories.Add(newName, page);

		if (oldDirectory.Files.Remove(oldName, out var file))
			newDirectory.Files.Add(newName, file);

		WriteDirectory(oldPage);
		WriteDirectory(newPage);
	}

	public IndexFile GetFile(string path)
	{
		var lastSeparator = path.LastIndexOf('/');

		var remaining = Array.Empty<string>();

		var page = lastSeparator == -1 ? _header.Page : FindDirectory(path[..lastSeparator], out remaining);
		var name = lastSeparator == -1 ? path : path[(lastSeparator + 1)..];

		if (remaining.Length > 0)
			return null;

		var directory = _directories[page];

		return directory.Files.GetValueOrDefault(name);
	}

	public void WriteFile(string path, IndexFile file)
	{
		var lastSeparator = path.LastIndexOf('/');

		var remaining = Array.Empty<string>();

		var page = lastSeparator == -1 ? _header.Page : FindDirectory(path[..lastSeparator], out remaining);
		var name = lastSeparator == -1 ? path : path[(lastSeparator + 1)..];

		page = remaining.Aggregate(page, CreateDirectory);

		var directory = _directories[page];

		if (directory.Directories.ContainsKey(name))
			return;

		if (!directory.Files.TryAdd(name, file))
			return;

		WriteDirectory(page);

		_fileReferences.TryAdd(file.Hash, 0);
		_fileReferences[file.Hash]++;
	}

	public bool DeleteFile(string path, out Hash hash)
	{
		var lastSeparator = path.LastIndexOf('/');

		var remaining = Array.Empty<string>();

		var page = lastSeparator == -1 ? _header.Page : FindDirectory(path[..lastSeparator], out remaining);
		var name = lastSeparator == -1 ? path : path[(lastSeparator + 1)..];

		if (remaining.Length > 0)
		{
			hash = default;

			return false;
		}

		var directory = _directories[page];
		var file = directory.Files.GetValueOrDefault(name);

		if (file == null)
		{
			hash = default;

			return false;
		}

		directory.Files.Remove(name);
		WriteDirectory(page);

		hash = file.Hash;

		_fileReferences[hash]--;

		if (_fileReferences[hash] != 0)
			return false;

		_fileReferences.Remove(hash);

		return true;
	}

	private async Task ReadDirectory(uint page, Progress progress, CancellationToken cancellationToken)
	{
		_stream.Position = (long)_pack.Locate(page);
		var directory = new IndexDirectory(_stream);
		_directories.Add(page, directory);

		foreach (var file in directory.Files.Values)
		{
			_fileReferences.TryAdd(file.Hash, 0);
			_fileReferences[file.Hash]++;
		}

		progress.Completed++;

		cancellationToken.ThrowIfCancellationRequested();

		foreach (var childPage in directory.Directories.Values)
			await ReadDirectory(childPage, progress, cancellationToken);
	}

	private void WriteDirectory(uint page)
	{
		var directory = _directories[page];

		_pack.Update(page, directory.Length);

		_stream.Position = (long)_pack.Locate(page);
		directory.Write(_stream);
	}

	private uint FindDirectory(string path, out string[] remaining)
	{
		var directories = path.Split('/', StringSplitOptions.RemoveEmptyEntries).ToArray();

		var page = _header.Page;

		for (var i = 0; i < directories.Length; i++)
		{
			var directory = _directories[page];
			var childName = directories[i];

			if (!directory.Directories.TryGetValue(childName, out var childPage))
			{
				remaining = directories[i..];

				return page;
			}

			page = childPage;
		}

		remaining = [];

		return page;
	}

	private uint CreateDirectory(uint parentPage, string childName)
	{
		var childPage = (uint)_pack.Add(IndexDirectory.Stride);

		_stream.Position = (long)_pack.Locate(childPage);
		var childDirectory = IndexDirectory.Create(_stream);

		_directories.Add(childPage, childDirectory);

		var parentDirectory = _directories[parentPage];
		parentDirectory.Directories.Add(childName, childPage);

		WriteDirectory(childPage);
		WriteDirectory(parentPage);

		return childPage;
	}

	public void SetHash(string path, Hash hash)
	{
		IndexFile file = GetFile(path);
		_fileReferences[file.Hash]--;
		if (_fileReferences[file.Hash] <= 0)
		{
			_fileReferences.Remove(file.Hash);
		}
        _fileReferences.Remove(file.Hash);

        file.Hash = hash;
        _fileReferences.TryAdd(hash, 0);
		_fileReferences[hash]++;
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);

		_pack.Dispose();
		_stream.Dispose();
	}
}
