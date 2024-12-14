using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldZoneRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("parentZoneId")]
	public uint ParentZoneId { get; set; }

	[TableColumn("allowAccess")]
	public bool AllowAccess { get; set; }

	[TableColumn("color")]
	public uint Color { get; set; }

	[TableColumn("soundZoneKitId")]
	public uint SoundZoneKitId { get; set; }

	[TableColumn("worldLocation2IdExit")]
	public uint WorldLocation2IdExit { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("zonePvpRulesEnum")]
	public uint ZonePvpRulesEnum { get; set; }

	[TableColumn("rewardRotationContentId")]
	public uint RewardRotationContentId { get; set; }
}
