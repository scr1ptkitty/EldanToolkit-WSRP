using LibNexus.Core.Extensions;
using System.IO;
using System.Linq;

namespace LibNexus.Files.ModelFiles;

public class ModelGeometryHeader
{
	public uint VertexCount { get; }
	public ushort VertexSize { get; }
	public ModelGeometryVertexFlags VertexFlags { get; }
	public ModelGeometryVertexFieldType[] VertexFieldTypes { get; }
	public byte[] VertexFieldPositions { get; }
	public ulong VertexTotalSize { get; }
	public ulong VertexOffset { get; }

	public uint IndexCount { get; }
	public byte IndexSize { get; }
	public ModelGeometryIndexFormat IndexFormat { get; }
	public ulong IndexTotalSize { get; }
	public ulong IndexOffset { get; }

	public ulong MeshCount { get; }
	public ulong MeshOffset { get; }

	public ulong Unk5Count { get; }
	public ulong Unk5Offset { get; }

	public ulong Unk6Count { get; }
	public ulong Unk6Offset { get; }

	public ulong Unk7Count { get; }
	public ulong Unk7Offset { get; }

	public ModelGeometryHeader(Stream stream)
	{
		var unk1 = stream.ReadUInt64();
		var unk2 = stream.ReadUInt64();
		var unk3 = stream.ReadUInt64();

		FileFormatException.ThrowIf<Model>(nameof(unk1), unk1 != 80);
		FileFormatException.ThrowIf<Model>(nameof(unk2), unk2 != 0);
		FileFormatException.ThrowIf<Model>(nameof(unk3), unk3 != 0);

		VertexCount = stream.ReadUInt32();
		VertexSize = stream.ReadUInt16();
		VertexFlags = (ModelGeometryVertexFlags)stream.ReadUInt16();
		VertexFieldTypes = stream.ReadBytes(11).Select(static value => (ModelGeometryVertexFieldType)value).ToArray();
		VertexFieldPositions = stream.ReadBytes(11);
		var vertexPadding = stream.ReadUInt16();
		VertexTotalSize = stream.ReadUInt64();
		VertexOffset = stream.ReadUInt64();

		FileFormatException.ThrowIf<Model>(nameof(vertexPadding), vertexPadding != 0);

		var unk4 = stream.ReadBytes(32);

		FileFormatException.ThrowIf<Model>(nameof(unk4), unk4.Any(static value => value != 0));

		IndexCount = stream.ReadUInt32();
		IndexSize = stream.ReadUInt8();
		IndexFormat = (ModelGeometryIndexFormat)stream.ReadByte();
		var indexPadding = stream.ReadUInt16();
		IndexTotalSize = stream.ReadUInt64();
		IndexOffset = stream.ReadUInt64();

		FileFormatException.ThrowIf<Model>(nameof(indexPadding), indexPadding != 0);

		MeshCount = stream.ReadUInt64();
		MeshOffset = stream.ReadUInt64();

		var vertexCount2 = stream.ReadUInt64();

		FileFormatException.ThrowIf<Model>(nameof(vertexCount2), VertexCount != vertexCount2);

		Unk5Count = stream.ReadUInt64();
		Unk5Offset = stream.ReadUInt64();
		Unk6Count = stream.ReadUInt64();
		Unk6Offset = stream.ReadUInt64();
		Unk7Count = stream.ReadUInt64();
		Unk7Offset = stream.ReadUInt64();
	}
}
