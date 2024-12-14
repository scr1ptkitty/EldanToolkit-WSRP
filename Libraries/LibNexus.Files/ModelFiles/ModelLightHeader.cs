using LibNexus.Core.Extensions;
using System;
using System.IO;
using System.Linq;
using System.Numerics;

namespace LibNexus.Files.ModelFiles;

public class ModelLightHeader
{
	byte[] fullData;
	public ushort BigData { get; }
	public Vector4 UnkVec { get; }
	public Vector3 Color { get; }
	public ModelChunk Unk2 { get; }
	public ulong AnimationKeyframes { get; }
    public uint[] AnimationTimes { get; }
    public Half[] AnimationValues { get; }

    public ModelLightHeader(Stream stream, ulong length)
	{
		// Should be 552 bytes?
		fullData = stream.ReadBytes(length);

		stream.Position = 4;
		BigData = stream.ReadUInt16();
		stream.Position += BigData * 400;

        UnkVec = new Vector4(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte() / 255f);

        stream.Position = 88;
		//Unk2 = new ModelChunk(stream.ReadUInt64(), stream.ReadUInt64());

		stream.Position = 448;
		Color = new Vector3(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte() / 255f);

		stream.Position = 136;
		AnimationKeyframes = stream.ReadUInt64();
		stream.Position = 432;
		AnimationTimes = new uint[AnimationKeyframes];
		for(var i = 0u; i < AnimationKeyframes; i++)
		{
			AnimationTimes[i] = stream.ReadUInt32();
		}
		stream.SkipPadding(16);

		AnimationValues = new Half[AnimationKeyframes];
		for(var i = 0u; i < AnimationKeyframes; i++)
		{
			AnimationValues[i] = stream.ReadHalf();
		}
		stream.SkipPadding(16);


        // Vector at 416?

        // Repeating pattern, 280, 304, 328. Does not seem to shift.

        // Repeating pattern, 416, 448, 480, 512, 544, 576, 608. Not always there. Found at 576, 608, 640 in soft_throb
		// Pattern 432 - 508, 4 bytes. 19 units. 136 has a 19.
		// 508-512 is padding?
	}
}
