using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneNemesisRegionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("mapZoneHexGroupId")]
	public uint MapZoneHexGroupId { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("faction2Id")]
	public uint Faction2Id { get; set; }
}
