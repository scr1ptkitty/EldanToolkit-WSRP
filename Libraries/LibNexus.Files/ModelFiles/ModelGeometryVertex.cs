using LibNexus.Core.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace LibNexus.Files.ModelFiles;

public class ModelGeometryVertex
{
	public Vector3 Position { get; }
	public Vector3 Tangent { get; }
	public Vector3 Normal { get; }
	public Vector3 Bitangent { get; }
	public byte[] Unk20 { get; } = [];
	public Vector4 Color1 { get; }
	public Vector4 Color2 { get; }
	public Vector2 Uv { get; }
	public byte[] Bones { get; } = [];

	public ModelGeometryVertex(Stream stream, ModelGeometryVertexFlags vertexFlags, IReadOnlyList<ModelGeometryVertexFieldType> vertexFieldTypes)
	{
		if (vertexFlags.HasFlag(ModelGeometryVertexFlags.Position))
			Position = ReadVector3(stream, vertexFieldTypes[0]);

		if (vertexFlags.HasFlag(ModelGeometryVertexFlags.Tangent))
			Tangent = ReadVector3(stream, vertexFieldTypes[1]);

		if (vertexFlags.HasFlag(ModelGeometryVertexFlags.Normal))
			Normal = ReadVector3(stream, vertexFieldTypes[2]);

		if (vertexFlags.HasFlag(ModelGeometryVertexFlags.Bitangent))
			Bitangent = ReadVector3(stream, vertexFieldTypes[3]);

		if (vertexFlags.HasFlag(ModelGeometryVertexFlags.Bones))
			Bones = stream.ReadBytes(4).Where(static b => b != byte.MaxValue).ToArray();

		if (vertexFlags.HasFlag(ModelGeometryVertexFlags.Unk0020))
			Unk20 = stream.ReadBytes(4);

		if (vertexFlags.HasFlag(ModelGeometryVertexFlags.Color1))
			Color1 = ReadVector4(stream, vertexFieldTypes[6]);

		if (vertexFlags.HasFlag(ModelGeometryVertexFlags.Color2))
			Color2 = ReadVector4(stream, vertexFieldTypes[7]);

		if (vertexFlags.HasFlag(ModelGeometryVertexFlags.Uv))
			Uv = ReadVector2(stream, vertexFieldTypes[8]);

		FileFormatException.ThrowIf<Model>(nameof(vertexFlags), vertexFlags.HasFlag(ModelGeometryVertexFlags.Unk0200));
		FileFormatException.ThrowIf<Model>(nameof(vertexFlags), vertexFlags.HasFlag(ModelGeometryVertexFlags.Unk0400));
		FileFormatException.ThrowIf<Model>(nameof(vertexFlags), vertexFlags.HasFlag(ModelGeometryVertexFlags.Unk0800));

		FileFormatException.ThrowIf<Model>(nameof(vertexFlags), vertexFlags.HasFlag(ModelGeometryVertexFlags.Unk1000));
		FileFormatException.ThrowIf<Model>(nameof(vertexFlags), vertexFlags.HasFlag(ModelGeometryVertexFlags.Unk2000));
		FileFormatException.ThrowIf<Model>(nameof(vertexFlags), vertexFlags.HasFlag(ModelGeometryVertexFlags.Unk4000));
		FileFormatException.ThrowIf<Model>(nameof(vertexFlags), vertexFlags.HasFlag(ModelGeometryVertexFlags.Unk8000));
	}

	private static Vector3 ReadVector3(Stream stream, ModelGeometryVertexFieldType vertexFieldType)
	{
		switch (vertexFieldType)
		{
			case ModelGeometryVertexFieldType.Vector3Float:
				return new Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle());

			case ModelGeometryVertexFieldType.Vector3Short:
				return new Vector3(stream.ReadInt16(), stream.ReadInt16(), stream.ReadInt16()) / 1024f;

			case ModelGeometryVertexFieldType.Vector3ByteXY:
			{
				var x = (stream.ReadUInt8() - 127) / 127f;
				var y = (stream.ReadUInt8() - 127) / 127f;
				var z = (float)Math.Sqrt(1 - x * x + y * y); // Distance should be 1, sqr(distrance) = 1, so x^2+y^2+z^2 = 1. That means z^2 = 1 - (x^2 + y^2)

				return new Vector3(x, y, z);
			}

			default:
				throw new FileFormatException(typeof(Model), nameof(vertexFieldType));
		}
	}

	private static Vector4 ReadVector4(Stream stream, ModelGeometryVertexFieldType vertexFieldType)
	{
		return vertexFieldType switch
		{
			ModelGeometryVertexFieldType.Vector4Byte => new Vector4(stream.ReadUInt8(), stream.ReadUInt8(), stream.ReadUInt8(), stream.ReadUInt8()) / 255f,
			_ => throw new FileFormatException(typeof(Model), nameof(vertexFieldType))
		};
	}

	private static Vector2 ReadVector2(Stream stream, ModelGeometryVertexFieldType vertexFieldType)
	{
		return vertexFieldType switch
		{
			ModelGeometryVertexFieldType.Vector2Short => new Vector2((float)stream.ReadHalf(), (float)stream.ReadHalf()),
			_ => throw new FileFormatException(typeof(Model), nameof(vertexFieldType))
		};
	}
}
