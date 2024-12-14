using LibNexus.Core.Extensions;
using System.IO;

namespace LibNexus.Files.TextureFiles;

public class TextureHeader
{
	public const uint Size = 100;

	public uint Width { get; }
	public uint Height { get; }
	public uint Depth { get; }
	public uint Sides { get; }
	public uint MipMaps { get; }
	public uint Format { get; }
	public bool IsJpg { get; }
	public uint JpgFormat { get; }
	public TextureJpgLayer[] JpgLayers { get; }
	public uint[] JpgSizes { get; }

	public TextureHeader(Stream stream)
	{
		Width = stream.ReadUInt32();
		Height = stream.ReadUInt32();
		Depth = stream.ReadUInt32();
		Sides = stream.ReadUInt32();
		MipMaps = stream.ReadUInt32();
		Format = stream.ReadUInt32();
		IsJpg = stream.ReadUInt32() != 0;

		JpgFormat = stream.ReadUInt32();
		JpgLayers = new TextureJpgLayer[4];

		for (var i = 0; i < JpgLayers.Length; i++)
			JpgLayers[i] = new TextureJpgLayer(stream.ReadUInt8(), stream.ReadUInt8(), stream.ReadUInt8());

		JpgSizes = new uint[stream.ReadUInt32()];

		for (var i = 0; i < 13; i++)
		{
			var size = stream.ReadUInt32();

			if (i < JpgSizes.Length)
				JpgSizes[i] = size;
		}

		FileFormatException.ThrowIf<Texture>("unused", stream.ReadUInt32() != 0);
	}
}
