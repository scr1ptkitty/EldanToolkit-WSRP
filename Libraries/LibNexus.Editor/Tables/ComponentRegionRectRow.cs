using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ComponentRegionRectRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("regionId")]
	public uint RegionId { get; set; }

	[TableColumn("rectMinX")]
	public uint RectMinX { get; set; }

	[TableColumn("rectMinY")]
	public uint RectMinY { get; set; }

	[TableColumn("rectLimX")]
	public uint RectLimX { get; set; }

	[TableColumn("rectLimY")]
	public uint RectLimY { get; set; }

	[TableColumn("componentLayoutId")]
	public uint ComponentLayoutId { get; set; }
}
