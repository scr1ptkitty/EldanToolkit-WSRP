using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class StoreLinkRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[TableColumn("categoryData")]
	public uint CategoryData { get; set; }

	[TableColumn("categoryDataPTR")]
	public uint CategoryDataPtr { get; set; }

	[TableColumn("accountItemId")]
	public uint AccountItemId { get; set; }
}
