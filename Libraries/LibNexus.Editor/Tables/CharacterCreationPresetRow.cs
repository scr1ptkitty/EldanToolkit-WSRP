using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterCreationPresetRow
{
	[TableColumn("id")]
	public uint Id { get; set; }

	[TableColumn("raceId")]
	public uint RaceId { get; set; }

	[TableColumn("faction2Id")]
	public uint Faction2Id { get; set; }

	[TableColumn("gender")]
	public uint Gender { get; set; }

	[TableColumn("stringPreset")]
	public string StringPreset { get; set; } = string.Empty;
}
