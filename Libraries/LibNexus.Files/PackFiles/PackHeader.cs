using LibNexus.Core.Extensions;
using System;
using System.IO;

namespace LibNexus.Files.PackFiles;

public class PackHeader
{
	private readonly Stream _stream;
	private readonly long _position;

	private ulong _length;
	private ulong _virtualPagesOffset;
	private ulong _virtualPages;
	private ulong _rootPage;

	public ulong Length
	{
		get => _length;

		set
		{
			if (_length == value)
				return;

			_length = value;

			_stream.SetLength((long)value);

			_stream.Position = _position + 512;
			_stream.WriteUInt64(value);
		}
	}

	public ulong VirtualPagesOffset
	{
		get => _virtualPagesOffset;

		set
		{
			if (_virtualPagesOffset == value)
				return;

			_virtualPagesOffset = value;

			_stream.Position = _position + 528;
			_stream.WriteUInt64(value);
		}
	}

	public ulong VirtualPages
	{
		get => _virtualPages;

		set
		{
			if (_virtualPages == value)
				return;

			_virtualPages = value;

			_stream.Position = _position + 536;
			_stream.WriteUInt64(value);
		}
	}

	public ulong RootPage
	{
		get => _rootPage;

		set
		{
			if (_rootPage == value)
				return;

			_rootPage = value;

			_stream.Position = _position + 544;
			_stream.WriteUInt64(value);
		}
	}

	public PackHeader(Stream stream)
	{
		_stream = stream;
		_position = stream.Position;

		var unk1 = new ulong[64]; // TODO value on translation archives, LauncherData.archive! these are also PhysicalPage offsets!

		for (var i = 0; i < unk1.Length; i++)
			unk1[i] = _stream.ReadUInt64();

		_length = _stream.ReadUInt64();
		_stream.ReadUInt64(); // TODO value on translation archives, LauncherData.archive! no idea yet what it is...
		_virtualPagesOffset = _stream.ReadUInt64();
		_virtualPages = _stream.ReadUInt64();
		_rootPage = _stream.ReadUInt64();
		var unk3 = _stream.ReadUInt64(); // TODO padding?

		if (_length != (ulong)_stream.Length)
			throw new Exception("PackHeader: Invalid size");

		if (unk3 != 0)
			throw new Exception("PackHeader: Invalid unk3");
	}

	public static PackHeader Create(Stream stream)
	{
		for (var i = 0; i < 64; i++)
			stream.WriteUInt64(0);

		stream.WriteUInt64((ulong)(stream.Position + 48L));
		stream.WriteUInt64(0);
		stream.WriteUInt64(0);
		stream.WriteUInt64(0);
		stream.WriteUInt64(0);
		stream.WriteUInt64(0);

		stream.Position -= 560;

		return new PackHeader(stream);
	}
}
