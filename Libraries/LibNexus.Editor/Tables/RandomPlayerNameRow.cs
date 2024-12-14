using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RandomPlayerNameRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("nameFragment")]
	public string NameFragment { get; set; } = string.Empty;

	[TableColumn("nameFragmentTypeEnum")]
	public uint NameFragmentTypeEnum { get; set; }

	[TableColumn("raceId")]
	public uint RaceId { get; set; }

	[TableColumn("gender")]
	public uint Gender { get; set; }

	[TableColumn("faction2Id")]
	public uint Faction2Id { get; set; }

	[TableColumn("languageFlags")]
	public uint LanguageFlags { get; set; }
}
