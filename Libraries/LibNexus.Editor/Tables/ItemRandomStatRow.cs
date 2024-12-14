using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemRandomStatRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("itemRandomStatGroupId")]
	public uint ItemRandomStatGroupId { get; set; }

	[TableColumn("weight")]
	public float Weight { get; set; }

	[TableColumn("itemStatTypeEnum")]
	public uint ItemStatTypeEnum { get; set; }

	[TableColumn("itemStatData")]
	public uint ItemStatData { get; set; }
}
