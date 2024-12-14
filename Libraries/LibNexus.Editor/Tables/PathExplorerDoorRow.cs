using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerDoorRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("worldZoneIdInsideMicro")]
	public uint WorldZoneIdInsideMicro { get; set; }

	[TableColumn("targetGroupIdActivate")]
	public uint TargetGroupIdActivate { get; set; }

	[TableColumn("targetGroupIdKill")]
	public uint TargetGroupIdKill { get; set; }
}
