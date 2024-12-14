using LibNexus.Core.Extensions;
using System;
using System.IO;

namespace LibNexus.Files;

public readonly struct Identifier : IEquatable<Identifier>
{
	public const uint Size = 8;

	public string Name { get; }
	public uint Version { get; }

	public Identifier(string name, uint version)
	{
		Name = name;
		Version = version;
	}

	public Identifier(Stream stream)
	{
		Name = stream.ReadWord();
		Version = stream.ReadUInt32();
	}

	public void Write(Stream stream)
	{
		stream.WriteWord(Name);
		stream.WriteUInt32(Version);
	}

	public override bool Equals(object obj)
	{
		return obj is Identifier other && Equals(other);
	}

	public bool Equals(Identifier other)
	{
		return Name == other.Name && Version == other.Version;
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Name, Version);
	}

	public static bool operator ==(Identifier left, Identifier right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Identifier left, Identifier right)
	{
		return !(left == right);
	}
}
