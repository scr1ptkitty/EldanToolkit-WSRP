using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class InputActionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("inputActionCategoryId")]
	public uint InputActionCategoryId { get; set; }

	[TableColumn("canHaveUpDownState")]
	public bool CanHaveUpDownState { get; set; }

	[TableColumn("displayIndex")]
	public uint DisplayIndex { get; set; }
}
