using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterCustomizationRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("raceId")]
	public uint RaceId { get; set; }

	[TableColumn("gender")]
	public uint Gender { get; set; }

	[TableColumn("itemSlotId")]
	public uint ItemSlotId { get; set; }

	[TableColumn("itemDisplayId")]
	public uint ItemDisplayId { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("characterCustomizationLabelId00")]
	public uint CharacterCustomizationLabelId00 { get; set; }

	[TableColumn("characterCustomizationLabelId01")]
	public uint CharacterCustomizationLabelId01 { get; set; }

	[TableColumn("value00")]
	public uint Value00 { get; set; }

	[TableColumn("value01")]
	public uint Value01 { get; set; }
}
