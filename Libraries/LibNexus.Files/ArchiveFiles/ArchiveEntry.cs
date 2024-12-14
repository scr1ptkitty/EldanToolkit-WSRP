using LibNexus.Core.Extensions;
using System;
using System.IO;

namespace LibNexus.Files.ArchiveFiles;

public class ArchiveEntry
{
	public const int Stride = 32;

	private readonly Stream _stream;
	private readonly Func<ulong> _getBasePosition;

	private uint Index { get; }

	private uint _page;
	private Hash _hash;
	private ulong _length;

	public uint Page
	{
		get => _page;

		set
		{
			if (_page == value)
				return;

			_stream.Position = (long)(Position + 0);
			_stream.WriteUInt32(value);

			_page = value;
		}
	}

	public Hash Hash
	{
		get => _hash;

		set
		{
			if (_hash == value)
				return;

			_stream.Position = (long)(Position + 4);
			_stream.WriteBytes(value.Bytes);

			_hash = value;
		}
	}

	public ulong Length
	{
		get => _length;

		set
		{
			if (_length == value)
				return;

			_stream.Position = (long)(Position + 24);
			_stream.WriteUInt64(value);

			_length = value;
		}
	}

	private ulong Position => _getBasePosition() + Index * Stride;

	public ArchiveEntry(Stream stream, Func<ulong> getBasePosition, uint index)
	{
		_stream = stream;
		_getBasePosition = getBasePosition;
		Index = index;

		_page = _stream.ReadUInt32();
		_hash = new Hash(_stream.ReadBytes(Hash.Length));
		_length = _stream.ReadUInt64();
	}

	public static ArchiveEntry Create(Stream stream, Func<ulong> getBasePosition, uint index)
	{
		stream.WriteUInt32(0);
		stream.WriteBytes(new byte[20]);
		stream.WriteUInt64(0);

		stream.Position -= 32;

		return new ArchiveEntry(stream, getBasePosition, index);
	}
}
