using LibNexus.Core.Extensions;
using System;
using System.IO;
using System.Numerics;

namespace LibNexus.Files.ModelFiles;

public class ModelBoneHeader
{
	public Matrix4x4 Rotation { get; set; }
	public Matrix4x4 Transform { get; set; }
	public Matrix4x4 InverseTransform { get; set; }
	public Vector3 Origin { get; set; }

	public ulong Animation1Entries { get; }
	public ulong Animation1TimeOffset { get; }
	public ulong Animation1ValueOffset { get; }
	public ulong Animation2Entries { get; }
	public ulong Animation2TimeOffset { get; }
	public ulong Animation2ValueOffset { get; }
	public ulong Animation3Entries { get; }
	public ulong Animation3TimeOffset { get; }
	public ulong Animation3ValueOffset { get; }
	public ulong Animation4Entries { get; }
	public ulong Animation4TimeOffset { get; }
	public ulong Animation4ValueOffset { get; }
	public ulong Animation5Entries { get; }
	public ulong Animation5TimeOffset { get; }
	public ulong Animation5ValueOffset { get; }
	public ulong Animation6Entries { get; }
	public ulong Animation6TimeOffset { get; }
	public ulong Animation6ValueOffset { get; }
	public ulong Animation7Entries { get; }
	public ulong Animation7TimeOffset { get; }
	public ulong Animation7ValueOffset { get; }
	public ulong Animation8Entries { get; }
	public ulong Animation8TimeOffset { get; }
	public ulong Animation8ValueOffset { get; }

	public Int16 unk1;
	public UInt16 unk2;
    public UInt16 unk3;
    public UInt16 unk4;
	public byte[] unk5;

	public ModelBoneHeader(Stream stream)
	{
		unk1 = stream.ReadInt16(); // TODO id?
		unk2 = stream.ReadUInt16(); // TODO flags?
		unk3 = stream.ReadUInt16(); // TODO parent?
		unk4 = stream.ReadUInt16(); // TODO mesh?

		Rotation = new Matrix4x4(stream.ReadUInt8(), 0, stream.ReadUInt8(), 0, 0, 1, 0, 0, stream.ReadUInt8(), 0, stream.ReadUInt8(), 0, 0, 0, 0, 1);
		unk5 = stream.ReadBytes(4); // TODO

		Animation1Entries = stream.ReadUInt64();
		Animation1TimeOffset = stream.ReadUInt64();
		Animation1ValueOffset = stream.ReadUInt64();
		Animation2Entries = stream.ReadUInt64();
		Animation2TimeOffset = stream.ReadUInt64();
		Animation2ValueOffset = stream.ReadUInt64();
		Animation3Entries = stream.ReadUInt64();
		Animation3TimeOffset = stream.ReadUInt64();
		Animation3ValueOffset = stream.ReadUInt64();
		Animation4Entries = stream.ReadUInt64();
		Animation4TimeOffset = stream.ReadUInt64();
		Animation4ValueOffset = stream.ReadUInt64();
		Animation5Entries = stream.ReadUInt64();
		Animation5TimeOffset = stream.ReadUInt64();
		Animation5ValueOffset = stream.ReadUInt64();
		Animation6Entries = stream.ReadUInt64();
		Animation6TimeOffset = stream.ReadUInt64();
		Animation6ValueOffset = stream.ReadUInt64();
		Animation7Entries = stream.ReadUInt64();
		Animation7TimeOffset = stream.ReadUInt64();
		Animation7ValueOffset = stream.ReadUInt64();
		Animation8Entries = stream.ReadUInt64();
		Animation8TimeOffset = stream.ReadUInt64();
		Animation8ValueOffset = stream.ReadUInt64();

		Transform = new Matrix4x4(
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle()
		);

		InverseTransform = new Matrix4x4(
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle()
		);

		Origin = new Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle());
	}
}
