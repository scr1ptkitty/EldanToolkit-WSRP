using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class DatacubeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("datacubeTypeEnum")]
	public uint DatacubeTypeEnum { get; set; }

	[TableColumn("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[TableColumn("localizedTextIdText00")]
	public uint LocalizedTextIdText00 { get; set; }

	[TableColumn("localizedTextIdText01")]
	public uint LocalizedTextIdText01 { get; set; }

	[TableColumn("localizedTextIdText02")]
	public uint LocalizedTextIdText02 { get; set; }

	[TableColumn("localizedTextIdText03")]
	public uint LocalizedTextIdText03 { get; set; }

	[TableColumn("localizedTextIdText04")]
	public uint LocalizedTextIdText04 { get; set; }

	[TableColumn("localizedTextIdText05")]
	public uint LocalizedTextIdText05 { get; set; }

	[TableColumn("soundEventId")]
	public uint SoundEventId { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("unlockCount")]
	public uint UnlockCount { get; set; }

	[TableColumn("assetPathImage")]
	public string AssetPathImage { get; set; } = string.Empty;

	[TableColumn("datacubeFactionEnum")]
	public uint DatacubeFactionEnum { get; set; }

	[TableColumn("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[TableColumn("questDirectionId")]
	public uint QuestDirectionId { get; set; }
}
