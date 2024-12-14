using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingPropertyInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("worldId")]
	public uint WorldId { get; set; }

	[TableColumn("housingMapInfoId")]
	public uint HousingMapInfoId { get; set; }

	[TableColumn("cost")]
	public uint Cost { get; set; }

	[TableColumn("housingFacingEnum")]
	public uint HousingFacingEnum { get; set; }

	[TableColumn("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("housingPropertyTypeId")]
	public uint HousingPropertyTypeId { get; set; }

	[TableColumn("worldLayerIdDefault00")]
	public uint WorldLayerIdDefault00 { get; set; }

	[TableColumn("worldLayerIdDefault01")]
	public uint WorldLayerIdDefault01 { get; set; }

	[TableColumn("worldLayerIdDefault02")]
	public uint WorldLayerIdDefault02 { get; set; }

	[TableColumn("worldLayerIdDefault03")]
	public uint WorldLayerIdDefault03 { get; set; }
}
