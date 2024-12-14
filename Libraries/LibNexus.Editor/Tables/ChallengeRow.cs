using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ChallengeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("challengeTypeEnum")]
	public uint ChallengeTypeEnum { get; set; }

	[TableColumn("target")]
	public uint Target { get; set; }

	[TableColumn("challengeFlags")]
	public uint ChallengeFlags { get; set; }

	[TableColumn("worldZoneIdRestriction")]
	public uint WorldZoneIdRestriction { get; set; }

	[TableColumn("triggerVolume2IdRestriction")]
	public uint TriggerVolume2IdRestriction { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("worldLocation2IdIndicator")]
	public uint WorldLocation2IdIndicator { get; set; }

	[TableColumn("worldLocation2IdStartLocation")]
	public uint WorldLocation2IdStartLocation { get; set; }

	[TableColumn("completionCount")]
	public uint CompletionCount { get; set; }

	[TableColumn("challengeTierId00")]
	public uint ChallengeTierId00 { get; set; }

	[TableColumn("challengeTierId01")]
	public uint ChallengeTierId01 { get; set; }

	[TableColumn("challengeTierId02")]
	public uint ChallengeTierId02 { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdProgress")]
	public uint LocalizedTextIdProgress { get; set; }

	[TableColumn("localizedTextIdAreaRestriction")]
	public uint LocalizedTextIdAreaRestriction { get; set; }

	[TableColumn("localizedTextIdLocation")]
	public uint LocalizedTextIdLocation { get; set; }

	[TableColumn("virtualItemIdDisplay")]
	public uint VirtualItemIdDisplay { get; set; }

	[TableColumn("targetGroupIdRewardPane")]
	public uint TargetGroupIdRewardPane { get; set; }

	[TableColumn("questDirectionIdActive")]
	public uint QuestDirectionIdActive { get; set; }

	[TableColumn("questDirectionIdInactive")]
	public uint QuestDirectionIdInactive { get; set; }

	[TableColumn("rewardTrackId")]
	public uint RewardTrackId { get; set; }
}
