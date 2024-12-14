using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillMaterialRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("item2IdStatRevolution")]
	public uint Item2IdStatRevolution { get; set; }

	[TableColumn("item2Id")]
	public uint Item2Id { get; set; }

	[TableColumn("displayIndex")]
	public uint DisplayIndex { get; set; }

	[TableColumn("tradeskillMaterialCategoryId")]
	public uint TradeskillMaterialCategoryId { get; set; }
}
