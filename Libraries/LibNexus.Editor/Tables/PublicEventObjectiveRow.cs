using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventObjectiveRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("publicEventId")]
	public uint PublicEventId { get; set; }

	[TableColumn("publicEventObjectiveFlags")]
	public uint PublicEventObjectiveFlags { get; set; }

	[TableColumn("publicEventObjectiveTypeSpecificFlags")]
	public uint PublicEventObjectiveTypeSpecificFlags { get; set; }

	[TableColumn("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[TableColumn("publicEventTeamId")]
	public uint PublicEventTeamId { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("localizedTextIdOtherTeam")]
	public uint LocalizedTextIdOtherTeam { get; set; }

	[TableColumn("localizedTextIdShort")]
	public uint LocalizedTextIdShort { get; set; }

	[TableColumn("localizedTextIdOtherTeamShort")]
	public uint LocalizedTextIdOtherTeamShort { get; set; }

	[TableColumn("publicEventObjectiveTypeEnum")]
	public uint PublicEventObjectiveTypeEnum { get; set; }

	[TableColumn("count")]
	public uint Count { get; set; }

	[TableColumn("objectId")]
	public uint ObjectId { get; set; }

	[TableColumn("failureTimeMs")]
	public uint FailureTimeMs { get; set; }

	[TableColumn("targetGroupIdRewardPane")]
	public uint TargetGroupIdRewardPane { get; set; }

	[TableColumn("publicEventObjectiveCategoryEnum")]
	public uint PublicEventObjectiveCategoryEnum { get; set; }

	[TableColumn("liveEventIdCounter")]
	public uint LiveEventIdCounter { get; set; }

	[TableColumn("publicEventObjectiveIdParent")]
	public uint PublicEventObjectiveIdParent { get; set; }

	[TableColumn("questDirectionId")]
	public uint QuestDirectionId { get; set; }

	[TableColumn("medalPointValue")]
	public uint MedalPointValue { get; set; }

	[TableColumn("localizedTextIdParticipantAdd")]
	public uint LocalizedTextIdParticipantAdd { get; set; }

	[TableColumn("localizedTextIdStart")]
	public uint LocalizedTextIdStart { get; set; }

	[TableColumn("displayOrder")]
	public uint DisplayOrder { get; set; }
}
