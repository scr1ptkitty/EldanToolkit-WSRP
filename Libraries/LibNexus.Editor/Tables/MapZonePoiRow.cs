using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZonePoiRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("mapZoneId")]
	public uint MapZoneId { get; set; }

	[TableColumn("pos0")]
	public uint Pos0 { get; set; }

	[TableColumn("pos1")]
	public uint Pos1 { get; set; }

	[TableColumn("pos2")]
	public uint Pos2 { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("mapZoneSpriteId")]
	public uint MapZoneSpriteId { get; set; }
}
