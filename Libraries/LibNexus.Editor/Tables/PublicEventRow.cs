using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("worldId")]
	public uint WorldId { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("failureTimeMs")]
	public uint FailureTimeMs { get; set; }

	[TableColumn("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[TableColumn("publicEventTypeEnum")]
	public uint PublicEventTypeEnum { get; set; }

	[TableColumn("publicEventIdParent")]
	public uint PublicEventIdParent { get; set; }

	[TableColumn("minPlayerLevel")]
	public uint MinPlayerLevel { get; set; }

	[TableColumn("liveEventIdLifetime")]
	public uint LiveEventIdLifetime { get; set; }

	[TableColumn("publicEventFlags")]
	public uint PublicEventFlags { get; set; }

	[TableColumn("localizedTextIdEnd")]
	public uint LocalizedTextIdEnd { get; set; }

	[TableColumn("rewardRotationContentId")]
	public uint RewardRotationContentId { get; set; }
}
