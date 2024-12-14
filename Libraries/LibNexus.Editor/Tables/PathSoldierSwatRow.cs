using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSoldierSwatRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("creature2Id")]
	public uint Creature2Id { get; set; }

	[TableColumn("targetGroupId")]
	public uint TargetGroupId { get; set; }

	[TableColumn("count")]
	public uint Count { get; set; }

	[TableColumn("virtualItemIdDisplay")]
	public uint VirtualItemIdDisplay { get; set; }
}
