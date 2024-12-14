using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterCustomizationSelectionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("characterCustomizationLabelId")]
	public uint CharacterCustomizationLabelId { get; set; }

	[TableColumn("value")]
	public uint Value { get; set; }

	[TableColumn("cost")]
	public ulong Cost { get; set; }
}
