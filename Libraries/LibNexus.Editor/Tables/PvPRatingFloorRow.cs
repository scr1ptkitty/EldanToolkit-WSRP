using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PvPRatingFloorRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("pvpRatingTypeEnum")]
	public uint PvpRatingTypeEnum { get; set; }

	[TableColumn("floorValue")]
	public uint FloorValue { get; set; }

	[TableColumn("localizedTextIdLabel")]
	public uint LocalizedTextIdLabel { get; set; }
}
