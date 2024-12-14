using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterCustomizationLabelRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("faction2Id")]
	public uint Faction2Id { get; set; }

	[TableColumn("displayIndex")]
	public uint DisplayIndex { get; set; }
}
