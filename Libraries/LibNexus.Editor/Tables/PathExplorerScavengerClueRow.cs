using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerScavengerClueRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdClue")]
	public uint LocalizedTextIdClue { get; set; }

	[TableColumn("explorerScavengerClueTypeEnum")]
	public uint ExplorerScavengerClueTypeEnum { get; set; }

	[TableColumn("creature2Id")]
	public uint Creature2Id { get; set; }

	[TableColumn("targetGroupId")]
	public uint TargetGroupId { get; set; }

	[TableColumn("activeRadius")]
	public float ActiveRadius { get; set; }

	[TableColumn("worldLocation2IdMiniMap")]
	public uint WorldLocation2IdMiniMap { get; set; }
}
