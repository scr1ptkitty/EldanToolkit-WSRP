using LibNexus.Core.Extensions;
using System;
using System.IO;

namespace LibNexus.Files.IndexFiles;

public class IndexFile
{
	public IndexFileFlags Flags { get; set; }
	public DateTime DateTime { get; set; }
	public ulong DecompressedSize { get; set; }
	public ulong CompressedSize { get; set; }
	public Hash Hash { get; set; }

	public IndexFile()
	{
	}

	public IndexFile(Stream stream)
	{
		Flags = (IndexFileFlags)stream.ReadUInt32();
		DateTime = DateTime.FromFileTimeUtc((long)stream.ReadUInt64());
		DecompressedSize = stream.ReadUInt64();
		CompressedSize = stream.ReadUInt64();
		Hash = new Hash(stream.ReadBytes(Hash.Length));

		if ((Flags & ~(IndexFileFlags.Complete | IndexFileFlags.Compressed)) != 0x00)
			throw new Exception("IndexFile: Invalid flags");
	}

	public void Write(Stream stream)
	{
		stream.WriteUInt32((uint)Flags);
		stream.WriteUInt64((ulong)DateTime.ToFileTimeUtc());
		stream.WriteUInt64(DecompressedSize);
		stream.WriteUInt64(CompressedSize);
		stream.WriteBytes(Hash.Bytes);
	}
}
