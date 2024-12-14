using LibNexus.Core.Extensions;
using System.IO;
using System.Numerics;

namespace LibNexus.Files.ModelFiles;

public class ModelGeometryMesh
{
	public uint StartIndex { get; }
	public uint StartVertex { get; }
	public uint IndexCount { get; }
	public uint VertexCount { get; }
	public ushort BonesIndex { get; }
	public ushort BonesCount { get; }
	public ushort Material { get; }
	public Vector3 Min { get; }
	public Vector3 Max { get; }
	public Vector3 Unk { get; }

	public ModelGeometryMesh(Stream stream)
	{
		StartIndex = stream.ReadUInt32();
		StartVertex = stream.ReadUInt32();
		IndexCount = stream.ReadUInt32();
		VertexCount = stream.ReadUInt32();
		BonesIndex = stream.ReadUInt16();
		BonesCount = stream.ReadUInt16();
		var unk1 = stream.ReadUInt16(); // TODO
		Material = stream.ReadUInt16();
		var unk2 = stream.ReadBytes(24); // TODO
		var unk14 = stream.ReadUInt32(); // TODO color?
		var unk15 = stream.ReadUInt32(); // TODO color?
		var unk16 = stream.ReadUInt64(); // TODO
		Min = new Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle());
		var minW = stream.ReadSingle();
		Max = new Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle());
		var maxW = stream.ReadSingle();
		Unk = new Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle()); // TODO origin?
		var unkW = stream.ReadSingle();

		FileFormatException.ThrowIf<Model>(nameof(minW), minW != 0);
		FileFormatException.ThrowIf<Model>(nameof(maxW), maxW != 0);
		FileFormatException.ThrowIf<Model>(nameof(unkW), unkW != 0);
	}
}
