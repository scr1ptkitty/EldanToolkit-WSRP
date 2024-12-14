using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneHexRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("mapZoneId")]
	public uint MapZoneId { get; set; }

	[TableColumn("pos0")]
	public uint Pos0 { get; set; }

	[TableColumn("pos1")]
	public uint Pos1 { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
