using LibNexus.Core.Extensions;
using System.IO;

namespace LibNexus.Files.ModelFiles;

public class ModelTextureHeader
{
	public ulong FileLength { get; }
	public ulong FileOffset { get; }

	public ModelTextureHeader(Stream stream)
	{
		stream.ReadBytes(16); // TODO
		FileLength = stream.ReadUInt64();
		FileOffset = stream.ReadUInt64();
	}
}
