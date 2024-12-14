using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneHexGroupRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("mapZoneId")]
	public uint MapZoneId { get; set; }
}
