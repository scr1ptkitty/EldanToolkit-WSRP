using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingResidenceInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("housingDecorInfoIdDefaultRoof")]
	public uint HousingDecorInfoIdDefaultRoof { get; set; }

	[TableColumn("housingDecorInfoIdDefaultEntryway")]
	public uint HousingDecorInfoIdDefaultEntryway { get; set; }

	[TableColumn("housingDecorInfoIdDefaultDoor")]
	public uint HousingDecorInfoIdDefaultDoor { get; set; }

	[TableColumn("housingWallpaperInfoIdDefault")]
	public uint HousingWallpaperInfoIdDefault { get; set; }

	[TableColumn("worldLocation2IdInside00")]
	public uint WorldLocation2IdInside00 { get; set; }

	[TableColumn("worldLocation2IdInside01")]
	public uint WorldLocation2IdInside01 { get; set; }

	[TableColumn("worldLocation2IdInside02")]
	public uint WorldLocation2IdInside02 { get; set; }

	[TableColumn("worldLocation2IdInside03")]
	public uint WorldLocation2IdInside03 { get; set; }

	[TableColumn("worldLocation2IdOutside00")]
	public uint WorldLocation2IdOutside00 { get; set; }

	[TableColumn("worldLocation2IdOutside01")]
	public uint WorldLocation2IdOutside01 { get; set; }

	[TableColumn("worldLocation2IdOutside02")]
	public uint WorldLocation2IdOutside02 { get; set; }

	[TableColumn("worldLocation2IdOutside03")]
	public uint WorldLocation2IdOutside03 { get; set; }
}
