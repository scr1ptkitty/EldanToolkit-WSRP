using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerDoorEntranceRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("pathExplorerDoorTypeEnumSurface")]
	public uint PathExplorerDoorTypeEnumSurface { get; set; }

	[TableColumn("pathExplorerDoorTypeEnumMicro")]
	public uint PathExplorerDoorTypeEnumMicro { get; set; }

	[TableColumn("creature2IdSurface")]
	public uint Creature2IdSurface { get; set; }

	[TableColumn("creature2IdMicro")]
	public uint Creature2IdMicro { get; set; }

	[TableColumn("pathExplorerDoorId")]
	public uint PathExplorerDoorId { get; set; }

	[TableColumn("worldLocation2IdSurfaceRevealed")]
	public uint WorldLocation2IdSurfaceRevealed { get; set; }
}
