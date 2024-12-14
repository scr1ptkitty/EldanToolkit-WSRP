using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneWorldJoinRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("mapZoneId")]
	public uint MapZoneId { get; set; }

	[TableColumn("worldId")]
	public uint WorldId { get; set; }
}
