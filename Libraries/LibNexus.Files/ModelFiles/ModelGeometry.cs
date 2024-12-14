using EldanToolkit.Libraries.LibNexus.Files;
using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;
using System.Diagnostics;
using System.IO;

namespace LibNexus.Files.ModelFiles;

public class ModelGeometry
{
	public ModelGeometryVertex[] Vertices { get; }
	public uint[] Indices { get; }
	public ModelGeometryMesh[] Meshes { get; set; }

	private readonly ModelGeometryHeader _header;

	public ModelGeometry(Stream stream)
	{
		_header = new ModelGeometryHeader(stream);
		stream.SkipPadding(16);

		using var dataStream = new SegmentStream(stream);

		Vertices = ReadVertices(dataStream);
		Indices = ReadIndices(dataStream);
		Meshes = ReadMeshes(dataStream);

		if (_header.Unk5Count != 0)
		{
			Goto(dataStream, nameof(_header.Unk5Offset), _header.Unk5Offset);
			dataStream.ReadBytes(_header.Unk5Count * 4); // TODO
			dataStream.SkipPadding(16);
		}

		if (_header.Unk6Count != 0)
        {
            Goto(dataStream, nameof(_header.Unk6Offset), _header.Unk6Offset);
			dataStream.ReadBytes(_header.Unk6Count * 2); // TODO
			dataStream.SkipPadding(16);
		}

		if (_header.Unk7Count != 0)
        {
            Goto(dataStream, nameof(_header.Unk7Offset), _header.Unk7Offset);

			for (var i = 0UL; i < _header.Unk7Count; i++)
				dataStream.ReadUInt32(); // TODO

			dataStream.SkipPadding(16);
		}
	}

	private ModelGeometryVertex[] ReadVertices(Stream stream)
    {
        Goto(stream, nameof(_header.VertexOffset), _header.VertexOffset);
        FileFormatException.ThrowIf<Model>(nameof(_header.VertexOffset), stream.Position != (long)_header.VertexOffset);

		var vertices = new ModelGeometryVertex[_header.VertexCount];

		for (var i = 0; i < _header.VertexCount; i++)
			vertices[i] = new ModelGeometryVertex(stream, _header.VertexFlags, _header.VertexFieldTypes);

		stream.SkipPadding(16);

		return vertices;
	}

	private uint[] ReadIndices(Stream stream)
    {
        Goto(stream, nameof(_header.IndexOffset), _header.IndexOffset);
        FileFormatException.ThrowIf<Model>(nameof(_header.IndexOffset), stream.Position != (long)_header.IndexOffset);

		var indices = new uint[_header.IndexCount];

		for (var i = 0; i < _header.IndexCount; i++)
		{
			indices[i] = _header.IndexFormat switch
			{
				ModelGeometryIndexFormat.Short => stream.ReadUInt16(),
				ModelGeometryIndexFormat.Int => stream.ReadUInt32(),
				_ => throw new FileFormatException(typeof(Model), nameof(_header.IndexFormat))
			};
		}

		stream.SkipPadding(16);

		return indices;
	}

	private ModelGeometryMesh[] ReadMeshes(SegmentStream stream)
    {
        Goto(stream, nameof(_header.MeshOffset), _header.MeshOffset);
        FileFormatException.ThrowIf<Model>(nameof(_header.MeshOffset), stream.Position != (long)_header.MeshOffset);

		var meshes = new ModelGeometryMesh[_header.MeshCount];

		for (var i = 0UL; i < _header.MeshCount; i++)
			meshes[i] = new ModelGeometryMesh(stream);

		stream.SkipPadding(16);

		return meshes;
    }

    public static void Goto(Stream stream, string field, ulong position)
    {
        stream.Goto<ModelGeometry>(field, position, Model.Debug);
    }
}
