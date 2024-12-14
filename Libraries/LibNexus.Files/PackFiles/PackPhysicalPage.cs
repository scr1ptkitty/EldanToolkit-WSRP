using LibNexus.Core.Extensions;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace LibNexus.Files.PackFiles;

public class PackPhysicalPage
{
	public const uint Stride = 16;

	private readonly Stream _stream;

	private ulong _position;
	private ulong _length;

	public ulong Position
	{
		get => _position;

		set
		{
			if (_position == value)
				return;

			_stream.Position = (long)(_position - Stride / 2);
			_stream.WriteUInt64(0);
			var data = _stream.ReadBytes(_length);
			_stream.WriteUInt64(0);

			_stream.Position = (long)(value - Stride / 2);
			_stream.WriteUInt64(_length);
			_stream.WriteBytes(data);
			_stream.WriteUInt64(_length);

			foreach (var virtualPage in VirtualPages)
				virtualPage.Offset = value;

			_position = value;
		}
	}

	public ulong Length
	{
		get => _length;

		set
		{
			if (_length == value)
				return;

			if (_length > value)
			{
				_stream.Position = (long)(_position + value);
				_stream.WriteBytes(new byte[_length - value]);
			}

			_stream.Position = (long)(_position - Stride / 2);
			_stream.WriteUInt64(value);

			_stream.Position = (long)(_position + _length);
			_stream.WriteUInt64(0);

			_stream.Position = (long)(_position + value);
			_stream.WriteUInt64(value);

			_length = value;
		}
	}

	public PackPhysicalPage Last { get; set; }
	public PackPhysicalPage Next { get; set; }
	public Collection<PackVirtualPage> VirtualPages { get; } = [];

	public PackPhysicalPage(Stream stream)
	{
		_stream = stream;
		_position = (ulong)_stream.Position + 8;

		_length = (ulong)Math.Abs((long)_stream.ReadUInt64()); // TODO length can be negative... If, what does it mean? Deleted ones?
		_stream.Position += (long)_length;
		var length2 = (ulong)Math.Abs((long)_stream.ReadUInt64()); // TODO length can be negative... If, what does it mean? Deleted ones?

		if (_length != length2)
			throw new Exception("PackPhysicalPage: Invalid length");
	}

	public static PackPhysicalPage Create(Stream stream, ulong length)
	{
		stream.WriteUInt64(length);
		stream.WriteBytes(new byte[length]);
		stream.WriteUInt64(length);

		stream.Position -= (long)(length + Stride);

		return new PackPhysicalPage(stream);
	}
}
