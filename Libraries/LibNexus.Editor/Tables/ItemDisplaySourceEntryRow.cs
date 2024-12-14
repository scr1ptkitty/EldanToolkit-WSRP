using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemDisplaySourceEntryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("itemSourceId")]
	public uint ItemSourceId { get; set; }

	[TableColumn("item2TypeId")]
	public uint Item2TypeId { get; set; }

	[TableColumn("itemMinLevel")]
	public uint ItemMinLevel { get; set; }

	[TableColumn("itemMaxLevel")]
	public uint ItemMaxLevel { get; set; }

	[TableColumn("itemDisplayId")]
	public uint ItemDisplayId { get; set; }

	[TableColumn("icon")]
	public string Icon { get; set; } = string.Empty;
}
