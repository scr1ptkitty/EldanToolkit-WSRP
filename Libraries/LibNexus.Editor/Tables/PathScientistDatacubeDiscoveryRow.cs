using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathScientistDatacubeDiscoveryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }
}
