using EldanToolkit.Libraries.LibNexus.Files;
using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibNexus.Files.ModelFiles;

public class Model
{
	public static bool Debug = false;

	private static readonly Identifier Identifier = new("MODL", 100);

	public ModelBone[] Bones { get; } = [];
	public ModelTexture[] Textures { get; } = [];
	public ModelMaterial[] Materials { get; } = [];
	public ModelGeometry[] Geometry { get; } = [];
	public ModelLight[] Lights { get; } = [];

	private readonly ModelHeader _header;

	public Model(Stream stream)
	{
		FileFormatException.ThrowIf<Model>(nameof(Identifier), new Identifier(stream) != Identifier);

		_header = new ModelHeader(stream);

		using var dataStream = new SegmentStream(stream);

		if (_header.Unk2.Count != 0)
        {
            Goto(dataStream, nameof(_header.Unk2), _header.Unk2.Offset);

            for (var i = 0UL; i < _header.Unk2.Count; i++)
			{
				stream.ReadBytes(112); // TODO
				dataStream.SkipPadding(16);
			}
		}

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk3), _header.Unk3.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk4), _header.Unk4.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk5), _header.Unk5.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk6), _header.Unk6.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk7), _header.Unk7.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk8), _header.Unk8.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk9), _header.Unk9.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk10), _header.Unk10.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk11), _header.Unk11.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk12), _header.Unk12.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk13), _header.Unk13.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk14), _header.Unk14.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk15), _header.Unk15.Count != 0 && Debug);

		if (_header.Unk16.Count != 0)
        {
            Goto(dataStream, nameof(_header.Unk16), _header.Unk16.Offset);

            for (var i = 0UL; i < _header.Unk16.Count; i++)
			{
				var unk1 = dataStream.ReadUInt16(); // TODO
				var unk2 = dataStream.ReadUInt16(); // TODO

				dataStream.ReadBytes(unk2 == ushort.MaxValue ? 188 : 204UL); // TODO
				dataStream.SkipPadding(16);
			}
		}

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk17), _header.Unk17.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk18), _header.Unk18.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk19), _header.Unk19.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk20), _header.Unk20.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk21), _header.Unk21.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk22), _header.Unk22.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk23), _header.Unk23.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk24), _header.Unk24.Count != 0 && Debug);

		if (_header.Bones.Count != 0)
        {
            Goto(dataStream, nameof(_header.Bones), _header.Bones.Offset);
            Bones = ReadBones(dataStream);
        }

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk26), _header.Unk26.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk27), _header.Unk27.Count != 0 && Debug);

		if (_header.Unk28.Count != 0)
        {
            Goto(dataStream, nameof(_header.Unk28), _header.Unk28.Offset);

            for (var i = 0UL; i < _header.Unk28.Count; i++)
				stream.ReadUInt16(); // TODO Bone related?

			dataStream.SkipPadding(16);
		}

		if (_header.Textures.Count != 0)
        {
            Goto(dataStream, nameof(_header.Textures), _header.Textures.Offset);
            Textures = ReadTextures(dataStream);
		}

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk30), _header.Unk30.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk31), _header.Unk31.Count != 0 && Debug);

		if (_header.Materials.Count != 0)
			Materials = ReadMaterials(dataStream);

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk33), _header.Unk31.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk34), _header.Unk34.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk35), _header.Unk35.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk36), _header.Unk36.Count != 0 && Debug);
		FileFormatException.ThrowIf<Model>(nameof(_header.Unk37), _header.Unk37.Count != 0 && Debug);

		if (_header.Geometry.Count != 0)
		{
			Goto(dataStream, nameof(_header.Geometry), _header.Geometry.Offset);
			Geometry = ReadGeometry(dataStream);
		}

		if (_header.Unk39.Count != 0)
		{
			Goto(dataStream, nameof(_header.Unk39), _header.Unk39.Offset);

			for (var i = 0UL; i < _header.Unk39.Count; i++)
			{
				stream.ReadBytes(16); // TODO
				dataStream.SkipPadding(16);
			}
		}

		if (_header.Unk40.Count != 0)
        {
            Goto(dataStream, nameof(_header.Unk40), _header.Unk40.Offset);

            for (var i = 0UL; i < _header.Unk40.Count; i++)
			{
				stream.ReadBytes(96); // TODO
				dataStream.SkipPadding(16);
			}
		}

		if (_header.Lights.Count != 0)
        {
            Goto(dataStream, nameof(_header.Lights), _header.Lights.Offset);
			Lights = ReadLights(dataStream);
		}

		if (_header.Unk42.Count != 0)
        {
            Goto(dataStream, nameof(_header.Unk42), _header.Unk42.Offset);

			for (var i = 0UL; i < _header.Unk42.Count; i++)
				stream.ReadBytes(96); // TODO

			dataStream.SkipPadding(16);
		}

		if (_header.Unk43.Count != 0)
        {
            Goto(dataStream, nameof(_header.Unk43), _header.Unk43.Offset);

			for (var i = 0UL; i < _header.Unk43.Count; i++)
				stream.ReadBytes(4); // TODO

			dataStream.SkipPadding(16);
		}

		if (_header.Unk44.Count != 0)
        {
            Goto(dataStream, nameof(_header.Unk44), _header.Unk44.Offset);

			var headers = new List<(ulong Count1, ulong Offset1, ulong Count2, ulong Offset2, ulong Count3, ulong Offset3, ulong Count4, ulong Offset4)>();

			for (var i = 0UL; i < _header.Unk44.Count; i++)
			{
				headers.Add(
					(dataStream.ReadUInt64(), dataStream.ReadUInt64(), dataStream.ReadUInt64(), dataStream.ReadUInt64(), dataStream.ReadUInt64(),
						dataStream.ReadUInt64(), dataStream.ReadUInt64(), dataStream.ReadUInt64())
				);

				dataStream.SkipPadding(16);
			}

			using var bodyStream = new SegmentStream(dataStream);

			foreach (var header in headers)
			{
				Goto(bodyStream, nameof(header.Offset1), header.Offset1);
				bodyStream.ReadBytes(header.Count1 * 16); // TODO
				bodyStream.SkipPadding(16);

                Goto(bodyStream, nameof(header.Offset2), header.Offset2);
				bodyStream.ReadBytes(header.Count2 * 12); // TODO
				bodyStream.SkipPadding(16);

                Goto(bodyStream, nameof(header.Offset3), header.Offset3);
				bodyStream.ReadBytes(header.Count3 * 4); // TODO
				bodyStream.SkipPadding(16);

                Goto(bodyStream, nameof(header.Offset4), header.Offset4);
				bodyStream.ReadBytes(header.Count4 * 20); // TODO
				bodyStream.SkipPadding(16);
			}
		}

		FileFormatException.ThrowIf<Model>(nameof(_header.Unk45), _header.Unk45.Count != 0 && Debug);

		FileFormatException.ThrowIf<Model>(nameof(dataStream), dataStream.Position != dataStream.Length && Debug);
    }

    public static void Goto(Stream stream, string field, ulong position)
    {
		stream.Goto<Model>(field, position, Debug);
    }

    private ModelBone[] ReadBones(SegmentStream stream)
    {
        Goto(stream, nameof(_header.Bones), _header.Bones.Offset);

		var headers = new ModelBoneHeader[_header.Bones.Count];

		for (var i = 0UL; i < _header.Bones.Count; i++)
		{
			headers[i] = new ModelBoneHeader(stream);
			stream.SkipPadding(16);
		}

		using var animationsStream = new SegmentStream(stream);
		var animations = new ModelBoneAnimation[_header.Bones.Count];

		for (var i = 0UL; i < _header.Bones.Count; i++)
		{
			animations[i] = new ModelBoneAnimation(animationsStream, headers[i]);
			stream.SkipPadding(16);
		}

		return Enumerable.Range(0, (int)_header.Bones.Count).Select(i => new ModelBone(headers[i], animations[i])).ToArray();
	}

	private ModelTexture[] ReadTextures(Stream stream)
    {
        Goto(stream, nameof(_header.Textures), _header.Textures.Offset);

		var headers = new ModelTextureHeader[_header.Textures.Count];

		for (var i = 0UL; i < _header.Textures.Count; i++)
		{
			headers[i] = new ModelTextureHeader(stream);
			stream.SkipPadding(16);
		}

		using var texturesStream = new SegmentStream(stream);
		var paths = new Dictionary<ulong, string>();

		for (var i = 0UL; i < _header.Textures.Count; i++)
		{
			paths.Add((ulong)texturesStream.Position, texturesStream.ReadWideString());
			texturesStream.SkipPadding(16);
		}

		return Enumerable.Range(0, (int)_header.Textures.Count).Select(i => new ModelTexture(headers[i], paths[headers[i].FileOffset])).ToArray();
	}

	private ModelMaterial[] ReadMaterials(SegmentStream stream)
    {
        Goto(stream, nameof(_header.Materials), _header.Materials.Offset);

		var headers = new ModelMaterialHeader[_header.Materials.Count];

		for (var i = 0UL; i < _header.Materials.Count; i++)
		{
			headers[i] = new ModelMaterialHeader(stream);
			stream.SkipPadding(16);
		}

		using var layersStream = new SegmentStream(stream);

		var layers = new ModelMaterialLayer[_header.Materials.Count][];

		for (var i = 0; i < headers.Length; i++)
		{
			var header = headers[i];

            Goto(layersStream, nameof(header.LayersOffset), header.LayersOffset);

			layers[i] = new ModelMaterialLayer[header.Layers];
			var layerHeaders = new ModelMaterialLayerHeader[header.Layers];

			for (var j = 0UL; j < header.Layers; j++)
				layerHeaders[j] = new ModelMaterialLayerHeader(layersStream);

			var chunkStream = new SegmentStream(stream);

			for (var j = 0; j < layerHeaders.Length; j++)
			{
				var layerHeader = layerHeaders[j];
				var datas = new byte[layerHeader.Chunks.Length][];

				for (var k = 0; k < layerHeader.Chunks.Length; k++)
				{
					var chunk = layerHeader.Chunks[k];

					if (!chunk.Active)
						continue;

					Goto(chunkStream, nameof(chunk.Offset), chunk.Offset);

					datas[k] = chunkStream.ReadBytes((chunk.LastValue - chunk.Offset) * 2); // TODO
				}

				layers[i][j] = new ModelMaterialLayer(layerHeader, datas);
			}

			layersStream.SkipPadding(16);
		}

		return Enumerable.Range(0, (int)_header.Materials.Count).Select(i => new ModelMaterial(headers[i], layers[i])).ToArray();
	}

	private ModelGeometry[] ReadGeometry(SegmentStream stream)
	{
		Goto(stream, nameof(_header.Geometry), _header.Geometry.Offset);

        var geometries = new ModelGeometry[_header.Geometry.Count];

        using var geometryStream = new SegmentStream(stream);

        for (var i = 0UL; i < _header.Geometry.Count; i++)
		{
            var geometry = new ModelGeometry(geometryStream);
            geometryStream.SkipPadding(16);
			geometries[i] = geometry;
        }

		return geometries;
	}

	private ModelLight[] ReadLights(SegmentStream stream)
	{
		Goto(stream, nameof(_header.Lights), _header.Lights.Offset);

		var lights = new ModelLight[_header.Lights.Count];

        using var lightStream = new SegmentStream(stream);

        for (var i = 0UL; i < _header.Lights.Count; i++)
        {
            var geometry = new ModelLight(lightStream, _header.Unk44.Offset - _header.Lights.Offset);
            lightStream.SkipPadding(16);
            lights[i] = geometry;
        }

        return lights;
	}
}
