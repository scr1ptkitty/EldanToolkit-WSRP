using System;
using System.IO;
using System.Linq;
using System.Text;

namespace LibNexus.Core.Extensions;

public static class StreamExtensions
{
	public static byte ReadUInt8(this Stream stream)
	{
		return stream.ReadBytes(1)[0];
	}

	public static short ReadInt16(this Stream stream)
	{
		return BitConverter.ToInt16(stream.ReadBytes(sizeof(short)));
	}

	public static ushort ReadUInt16(this Stream stream)
	{
		return BitConverter.ToUInt16(stream.ReadBytes(sizeof(ushort)));
	}

	public static uint ReadUInt32(this Stream stream)
	{
		return BitConverter.ToUInt32(stream.ReadBytes(sizeof(uint)));
	}

	public static ulong ReadUInt64(this Stream stream)
	{
		return BitConverter.ToUInt64(stream.ReadBytes(sizeof(ulong)));
	}

	public static Half ReadHalf(this Stream stream)
	{
		return BitConverter.ToHalf(stream.ReadBytes(2));
	}

	public static float ReadSingle(this Stream stream)
	{
		return BitConverter.ToSingle(stream.ReadBytes(sizeof(float)));
	}

	public static string ReadWord(this Stream stream)
	{
		return Encoding.ASCII.GetString(ReadBytes(stream, sizeof(uint)).Reverse().ToArray());
	}

	public static string ReadString(this Stream stream, ulong? length = null)
	{
		var value = string.Empty;

		for (var i = 0UL; length == null || i < length; i++)
		{
			var character = stream.ReadBytes(sizeof(byte))[0];

			if (length == null && character == 0x00)
				break;

			value += (char)character;
		}

		return value.Split('\0')[0];
	}

	public static string ReadWideString(this Stream stream, ulong? length = null)
	{
		var value = string.Empty;

		for (var i = 0UL; length == null || i < length; i++)
		{
			var character = BitConverter.ToUInt16(stream.ReadBytes(sizeof(ushort)));

			if (length == null && character == 0x00)
				break;

			value += (char)character;
		}

		return value.Split('\0')[0];
	}

	public static byte[] ReadBytes(this Stream stream, ulong length)
	{
		var result = new byte[length];
		var read = 0UL;

		while (read < length && stream.Position < stream.Length)
			read += (ulong)stream.Read(result, (int)read, (int)(length - read));

		return result;
	}

	public static void WriteUInt32(this Stream stream, uint value)
	{
		stream.WriteBytes(BitConverter.GetBytes(value));
	}

	public static void WriteUInt64(this Stream stream, ulong value)
	{
		stream.WriteBytes(BitConverter.GetBytes(value));
	}

	public static void WriteWord(this Stream stream, string value)
	{
		if (value.Length != sizeof(uint))
			throw new OverflowException("A word must be 4 characters long.");

		stream.WriteBytes(Encoding.ASCII.GetBytes(value).Reverse().ToArray());
	}

	public static void WriteString(this Stream stream, string value)
	{
		stream.WriteBytes(Encoding.ASCII.GetBytes(value));
		stream.WriteBytes(new byte[1]);
	}

	public static void WriteBytes(this Stream stream, byte[] value)
	{
		stream.Write(value);
	}

	public static void SkipPadding(this Stream stream, ulong size)
	{
		if (stream.Position % (long)size != 0)
			stream.Position += (long)(size - (ulong)(stream.Position % (long)size));
	}
}
