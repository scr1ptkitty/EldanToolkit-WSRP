using LibNexus.Core.Extensions;
using System.IO;

namespace LibNexus.Files.TranslationsFiles;

public class TranslationHeader
{
	public uint Id { get; }
	public ulong NameLength { get; }
	public ulong NameOffset { get; }
	public ulong CodeLength { get; }
	public ulong CodeOffset { get; }
	public ulong DescriptionLength { get; }
	public ulong DescriptionOffset { get; }
	public ulong TranslationsAmount { get; }
	public ulong TranslationsOffset { get; }
	public ulong StringsLength { get; }
	public ulong StringsOffset { get; }

	public TranslationHeader(Stream stream)
	{
		Id = stream.ReadUInt32();
		var unk = stream.ReadUInt32(); // TODO What is this?! Maybe an .tbl id?
		NameLength = stream.ReadUInt64();
		NameOffset = stream.ReadUInt64();
		CodeLength = stream.ReadUInt64();
		CodeOffset = stream.ReadUInt64();
		DescriptionLength = stream.ReadUInt64();
		DescriptionOffset = stream.ReadUInt64();
		TranslationsAmount = stream.ReadUInt64();
		TranslationsOffset = stream.ReadUInt64();
		StringsLength = stream.ReadUInt64();
		StringsOffset = stream.ReadUInt64();
	}
}
