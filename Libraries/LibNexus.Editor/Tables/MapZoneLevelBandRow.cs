using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneLevelBandRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("mapZoneHexGroupId")]
	public uint MapZoneHexGroupId { get; set; }

	[TableColumn("levelMin")]
	public uint LevelMin { get; set; }

	[TableColumn("levelMax")]
	public uint LevelMax { get; set; }

	[TableColumn("labelX")]
	public uint LabelX { get; set; }

	[TableColumn("labelZ")]
	public uint LabelZ { get; set; }
}
