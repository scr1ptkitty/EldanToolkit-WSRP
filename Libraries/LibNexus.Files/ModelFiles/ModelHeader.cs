using LibNexus.Core.Extensions;
using System.IO;

namespace LibNexus.Files.ModelFiles;

public class ModelHeader
{
	public const long Size = 1584;

	public ModelChunk Unk2 { get; }
	public ModelChunk Unk3 { get; }
	public ModelChunk Unk4 { get; }
	public ModelChunk Unk5 { get; }
	public ModelChunk Unk6 { get; }
	public ModelChunk Unk7 { get; }
	public ModelChunk Unk8 { get; }
	public ModelChunk Unk9 { get; }
	public ModelChunk Unk10 { get; }
	public ModelChunk Unk11 { get; }
	public ModelChunk Unk12 { get; }
	public ModelChunk Unk13 { get; }
	public ModelChunk Unk14 { get; }
	public ModelChunk Unk15 { get; }
	public ModelChunk Unk16 { get; }
	public ModelChunk Unk17 { get; }
	public ModelChunk Unk18 { get; }
	public ModelChunk Unk19 { get; }
	public ModelChunk Unk20 { get; }
	public ModelChunk Unk21 { get; }
	public ModelChunk Unk22 { get; }
	public ModelChunk Unk23 { get; }
	public ModelChunk Unk24 { get; }
	public ModelChunk Bones { get; }
	public ModelChunk Unk26 { get; }
	public ModelChunk Unk27 { get; }
	public ModelChunk Unk28 { get; }
	public ModelChunk Textures { get; }
	public ModelChunk Unk30 { get; }
	public ModelChunk Unk31 { get; }
	public ModelChunk Materials { get; }
	public ModelChunk Unk33 { get; }
	public ModelChunk Unk34 { get; }
	public ModelChunk Unk35 { get; }
	public ModelChunk Unk36 { get; }
	public ModelChunk Unk37 { get; }
	public ModelChunk Geometry { get; }
	public ModelChunk Unk39 { get; }
	public ModelChunk Unk40 { get; }
	public ModelChunk Lights { get; }
	public ModelChunk Unk42 { get; }
	public ModelChunk Unk43 { get; }
	public ModelChunk Unk44 { get; }
	public ModelChunk Unk45 { get; }

	public ModelHeader(Stream stream)
	{
		var unk1 = stream.ReadUInt64(); // TODO
		FileFormatException.ThrowIf<Model>(nameof(unk1), unk1 != 1);

		Unk2 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk3 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk4 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk5 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk6 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk7 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk8 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk9 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk10 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk11 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk12 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk13 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk14 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk15 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk16 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk17 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk18 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk19 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk20 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk21 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk22 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk23 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk24 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Bones = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk26 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk27 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk28 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Textures = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk30 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk31 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Materials = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk33 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk34 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk35 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64()); // vertices, according to Wildstar Studio
		Unk36 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64()); // indices
		Unk37 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64()); // submeshes
		Geometry = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk39 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk40 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		stream.ReadBytes(152); // TODO
		Lights = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk42 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk43 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		stream.ReadBytes(328); // TODO
		Unk44 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		Unk45 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());
		stream.ReadBytes(384); // TODO
	}
}
