using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneHexGroupEntryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("mapZoneHexGroupId")]
	public uint MapZoneHexGroupId { get; set; }

	[TableColumn("hexX")]
	public uint HexX { get; set; }

	[TableColumn("hexY")]
	public uint HexY { get; set; }
}
