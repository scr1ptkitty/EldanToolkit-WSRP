using LibNexus.Core.Extensions;
using System;
using System.IO;

namespace LibNexus.Files.IndexFiles;

public class IndexHeader
{
	private const string Magic = "AIDX";
	private const uint Version = 1;
	public const uint Stride = 16;

	private readonly Stream _stream;
	private readonly long _position;

	private uint _build;
	private uint _page;

	public uint Build
	{
		get => _build;

		set
		{
			if (_build == value)
				return;

			_stream.Position = _position + 8;
			_stream.WriteUInt32(value);

			_build = value;
		}
	}

	public uint Page
	{
		get => _page;

		set
		{
			if (_page == value)
				return;

			_stream.Position = _position + 12;
			_stream.WriteUInt32(value);

			_page = value;
		}
	}

	public IndexHeader(Stream stream)
	{
		_stream = stream;
		_position = _stream.Position;

		var magic = _stream.ReadWord();
		var version = _stream.ReadUInt32();

		if (magic != Magic)
			throw new Exception("IndexHeader: Invalid magic");

		if (version != Version)
			throw new Exception("IndexHeader: Invalid version");

		_build = _stream.ReadUInt32();
		_page = _stream.ReadUInt32();
	}

	public static IndexHeader Create(Stream stream)
	{
		stream.WriteWord(Magic);
		stream.WriteUInt32(Version);
		stream.WriteUInt32(0);
		stream.WriteUInt32(0);

		stream.Position -= Stride;

		return new IndexHeader(stream);
	}
}
