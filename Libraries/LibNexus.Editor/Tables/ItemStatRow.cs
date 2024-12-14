using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemStatRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("itemStatTypeEnum00")]
	public uint ItemStatTypeEnum00 { get; set; }

	[TableColumn("itemStatTypeEnum01")]
	public uint ItemStatTypeEnum01 { get; set; }

	[TableColumn("itemStatTypeEnum02")]
	public uint ItemStatTypeEnum02 { get; set; }

	[TableColumn("itemStatTypeEnum03")]
	public uint ItemStatTypeEnum03 { get; set; }

	[TableColumn("itemStatTypeEnum04")]
	public uint ItemStatTypeEnum04 { get; set; }

	[TableColumn("itemStatData00")]
	public uint ItemStatData00 { get; set; }

	[TableColumn("itemStatData01")]
	public uint ItemStatData01 { get; set; }

	[TableColumn("itemStatData02")]
	public uint ItemStatData02 { get; set; }

	[TableColumn("itemStatData03")]
	public uint ItemStatData03 { get; set; }

	[TableColumn("itemStatData04")]
	public uint ItemStatData04 { get; set; }
}
