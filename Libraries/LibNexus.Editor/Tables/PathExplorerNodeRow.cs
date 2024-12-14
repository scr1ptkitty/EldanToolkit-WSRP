using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerNodeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("pathExplorerAreaId")]
	public uint PathExplorerAreaId { get; set; }

	[TableColumn("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[TableColumn("spline2Id")]
	public uint Spline2Id { get; set; }

	[TableColumn("localizedTextIdSettlerButton")]
	public uint LocalizedTextIdSettlerButton { get; set; }

	[TableColumn("questDirectionId")]
	public uint QuestDirectionId { get; set; }

	[TableColumn("visualEffectId")]
	public uint VisualEffectId { get; set; }
}
