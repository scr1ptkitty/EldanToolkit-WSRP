using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibNexus.Files.TranslationsFiles;

public class Translation
{
	private static readonly Identifier Identifier = new("LTEX", 4);

	public string Name { get; }
	public string Code { get; }
	public string Description { get; }
	public Dictionary<uint, string> Translations { get; }

	private readonly TranslationHeader _header;

	public Translation(Stream stream)
	{
		FileFormatException.ThrowIf<Translation>(nameof(Identifier), new Identifier(stream) != Identifier);

		_header = new TranslationHeader(stream);

		using var dataStream = new SegmentStream(stream);

		Name = ReadName(dataStream);
		Code = ReadCode(dataStream);
		Description = ReadDescription(dataStream);
		var translations = ReadTranslations(dataStream);
		var strings = ReadStrings(dataStream);

		FileFormatException.ThrowIf<Translation>(nameof(stream), stream.Position != stream.Length);

		Translations = translations.ToDictionary(static entry => entry.Key, entry => strings[entry.Value]);
	}

	private string ReadName(Stream stream)
	{
		FileFormatException.ThrowIf<Translation>(nameof(_header.NameOffset), (ulong)stream.Position != _header.NameOffset);
		var name = stream.ReadWideString(_header.NameLength);
		stream.SkipPadding(16);

		return name;
	}

	private string ReadCode(Stream stream)
	{
		FileFormatException.ThrowIf<Translation>(nameof(_header.CodeOffset), (ulong)stream.Position != _header.CodeOffset);
		var code = stream.ReadWideString(_header.CodeLength);
		stream.SkipPadding(16);

		return code;
	}

	private string ReadDescription(Stream stream)
	{
		FileFormatException.ThrowIf<Translation>(nameof(_header.DescriptionOffset), (ulong)stream.Position != _header.DescriptionOffset);
		var description = stream.ReadWideString(_header.DescriptionLength);
		stream.SkipPadding(16);

		return description;
	}

	private Dictionary<uint, uint> ReadTranslations(Stream stream)
	{
		var translations = new Dictionary<uint, uint>();
		FileFormatException.ThrowIf<Translation>(nameof(_header.TranslationsOffset), (ulong)stream.Position != _header.TranslationsOffset);

		for (var i = 0UL; i < _header.TranslationsAmount; i++)
			translations.Add(stream.ReadUInt32(), stream.ReadUInt32());

		stream.SkipPadding(16);

		return translations;
	}

	private Dictionary<uint, string> ReadStrings(Stream stream)
	{
		FileFormatException.ThrowIf<Translation>(nameof(_header.StringsOffset), (ulong)stream.Position != _header.StringsOffset);

		using var stringsStream = new SegmentStream(stream, (long)_header.StringsOffset, (long)(_header.StringsLength * 2));

		var strings = new Dictionary<uint, string>();

		while (stringsStream.Position < stringsStream.Length)
			strings.Add((uint)stringsStream.Position / 2, stringsStream.ReadWideString());

		stream.SkipPadding(16);

		return strings;
	}
}
