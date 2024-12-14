using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CityDirectionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("cityDirectionTypeEnum")]
	public uint CityDirectionTypeEnum { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("worldLocation2Id00")]
	public uint WorldLocation2Id00 { get; set; }

	[TableColumn("worldLocation2Id01")]
	public uint WorldLocation2Id01 { get; set; }

	[TableColumn("worldLocation2Id02")]
	public uint WorldLocation2Id02 { get; set; }

	[TableColumn("worldLocation2Id03")]
	public uint WorldLocation2Id03 { get; set; }
}
