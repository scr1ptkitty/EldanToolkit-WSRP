using LibNexus.Core.Extensions;
using System.IO;

namespace LibNexus.Files.ModelFiles;

public class ModelMaterialHeader
{
	public const ulong Size = 48;

	public ulong Layers { get; }
	public ulong LayersOffset { get; }

    public ModelMaterialHeader(Stream stream)
	{
		stream.ReadBytes(32); // TODO
		Layers = stream.ReadUInt64();
		LayersOffset = stream.ReadUInt64();
	}
}
