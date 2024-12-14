using LibNexus.Core.Extensions;
using System.IO;

namespace LibNexus.Files.ModelFiles;

public class ModelMaterialLayerHeader
{
	public ModelMaterialLayerChunk[] Chunks { get; }

	public ModelMaterialLayerHeader(Stream stream)
	{
		var texture1 = stream.ReadUInt16();
		var texture2 = stream.ReadUInt16();
		var unk1 = stream.ReadUInt32(); // TODO
		var unk2 = stream.ReadUInt32(); // TODO
		var unk3 = stream.ReadUInt32(); // TODO
		var unk4 = stream.ReadUInt32(); // TODO
		var unk5 = stream.ReadUInt32(); // TODO

		Chunks = new ModelMaterialLayerChunk[11];

		for (var i = 0; i < 11; i++)
			Chunks[i] = new ModelMaterialLayerChunk(stream.ReadUInt64() == 1, stream.ReadUInt64(), stream.ReadUInt64());

		var unk6 = stream.ReadUInt32(); // TODO
		var unk7 = stream.ReadUInt32(); // TODO
	}
}
