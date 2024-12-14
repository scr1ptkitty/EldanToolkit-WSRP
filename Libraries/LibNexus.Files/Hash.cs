using LibNexus.Core.Extensions;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace LibNexus.Files;

public readonly struct Hash : IEquatable<Hash>
{
	public const uint Length = 20;

	public byte[] Bytes { get; } = new byte[Length];

	public Hash(byte[] bytes)
	{
		Array.Copy(bytes, Bytes, Length);
	}

	public Hash(Stream stream)
	{
		Bytes = stream.ReadBytes(Length);
	}

	public void Write(Stream stream)
	{
		stream.WriteBytes(Bytes);
	}

	public static Hash Create(byte[] data)
	{
		return new Hash(SHA1.HashData(data));
	}

	public bool Validate(byte[] data)
	{
		return Bytes.SequenceEqual(SHA1.HashData(data));
	}

	public override bool Equals(object obj)
	{
		return obj is Hash other && Equals(other);
	}

	public bool Equals(Hash other)
	{
		return other.Bytes.SequenceEqual(Bytes);
	}

	public override int GetHashCode()
	{
		return Bytes.GetHashCode();
	}

	public static bool operator ==(Hash left, Hash right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Hash left, Hash right)
	{
		return !(left == right);
	}
}
