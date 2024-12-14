using LibNexus.Core.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibNexus.Files.IndexFiles;

public class IndexDirectory
{
	public const uint Stride = 8;
	private const uint DirectoryStride = 8;
	private const uint FileStride = 56;

	public Dictionary<string, uint> Directories { get; } = [];
	public Dictionary<string, IndexFile> Files { get; } = [];

	public ulong Length
	{
		get
		{
			var length = (ulong)Stride;

			length += (ulong)Directories.Keys.Sum(static name => name.Length + 1 + DirectoryStride);
			length += (ulong)Files.Keys.Sum(static name => name.Length + 1 + FileStride);

			return length;
		}
	}

	public IndexDirectory(Stream stream)
	{
		var directories = stream.ReadUInt32();
		var files = stream.ReadUInt32();

		var startOffset = stream.Position;
		var stringsOffset = startOffset + directories * DirectoryStride + files * FileStride;

		for (var i = 0; i < directories; i++)
		{
			stream.Position = startOffset + i * DirectoryStride;
			var nameOffset = stream.ReadUInt32();
			var block = stream.ReadUInt32();

			stream.Position = stringsOffset + nameOffset;
			var name = stream.ReadString();

			Directories.Add(name, block);
		}

		startOffset += directories * DirectoryStride;

		for (var i = 0; i < files; i++)
		{
			stream.Position = startOffset + i * FileStride;
			var nameOffset = stream.ReadUInt32();
			var file = new IndexFile(stream);
			stream.ReadUInt32(); // TODO value on translation archives, LauncherData.archive! no idea yet what it is...

			stream.Position = stringsOffset + nameOffset;
			var name = stream.ReadString();

			Files.Add(name, file);
		}
	}

	public void Write(Stream stream)
	{
		stream.WriteUInt32((uint)Directories.Count);
		stream.WriteUInt32((uint)Files.Count);

		var stringsOffset = 0U;

		foreach (var (name, block) in Directories)
		{
			stream.WriteUInt32(stringsOffset);
			stream.WriteUInt32(block);
			stringsOffset += (uint)(name.Length + 1);
		}

		foreach (var (name, file) in Files)
		{
			stream.WriteUInt32(stringsOffset);
			file.Write(stream);
			stringsOffset += (uint)(name.Length + 1);
		}

		foreach (var name in Directories.Keys)
			stream.WriteString(name);

		foreach (var name in Files.Keys)
			stream.WriteString(name);
	}

	public static IndexDirectory Create(Stream stream)
	{
		stream.WriteUInt32(0);
		stream.WriteUInt32(0);

		stream.Position -= Stride;

		return new IndexDirectory(stream);
	}
}
