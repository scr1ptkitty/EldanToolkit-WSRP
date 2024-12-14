using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Quest2Row
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[TableColumn("localizedTextIdText")]
	public uint LocalizedTextIdText { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("conLevel")]
	public uint ConLevel { get; set; }

	[TableColumn("type")]
	public uint Type { get; set; }

	[TableColumn("preq_level")]
	public uint PreqLevel { get; set; }

	[TableColumn("preq_flags")]
	public uint PreqFlags { get; set; }

	[TableColumn("preq_quest0")]
	public uint PreqQuest0 { get; set; }

	[TableColumn("preq_quest01")]
	public uint PreqQuest01 { get; set; }

	[TableColumn("preq_quest02")]
	public uint PreqQuest02 { get; set; }

	[TableColumn("preq_race")]
	public uint PreqRace { get; set; }

	[TableColumn("preq_item")]
	public uint PreqItem { get; set; }

	[TableColumn("questPlayerFactionEnum")]
	public uint QuestPlayerFactionEnum { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("localizedTextIdCompletionOverride")]
	public uint LocalizedTextIdCompletionOverride { get; set; }

	[TableColumn("reward_xpOverride")]
	public uint RewardXpOverride { get; set; }

	[TableColumn("reward_cashOverride")]
	public uint RewardCashOverride { get; set; }

	[TableColumn("pushed_itemId0")]
	public uint PushedItemId0 { get; set; }

	[TableColumn("pushed_itemId01")]
	public uint PushedItemId01 { get; set; }

	[TableColumn("pushed_itemId02")]
	public uint PushedItemId02 { get; set; }

	[TableColumn("pushed_itemId03")]
	public uint PushedItemId03 { get; set; }

	[TableColumn("pushed_itemId04")]
	public uint PushedItemId04 { get; set; }

	[TableColumn("pushed_itemId05")]
	public uint PushedItemId05 { get; set; }

	[TableColumn("pushed_itemCount0")]
	public uint PushedItemCount0 { get; set; }

	[TableColumn("pushed_itemCount01")]
	public uint PushedItemCount01 { get; set; }

	[TableColumn("pushed_itemCount02")]
	public uint PushedItemCount02 { get; set; }

	[TableColumn("pushed_itemCount03")]
	public uint PushedItemCount03 { get; set; }

	[TableColumn("pushed_itemCount04")]
	public uint PushedItemCount04 { get; set; }

	[TableColumn("pushed_itemCount05")]
	public uint PushedItemCount05 { get; set; }

	[TableColumn("objective0")]
	public uint Objective0 { get; set; }

	[TableColumn("objective01")]
	public uint Objective01 { get; set; }

	[TableColumn("objective02")]
	public uint Objective02 { get; set; }

	[TableColumn("objective03")]
	public uint Objective03 { get; set; }

	[TableColumn("objective04")]
	public uint Objective04 { get; set; }

	[TableColumn("objective05")]
	public uint Objective05 { get; set; }

	[TableColumn("localizedTextIdGiverTextUnknown")]
	public uint LocalizedTextIdGiverTextUnknown { get; set; }

	[TableColumn("localizedTextIdGiverTextAccepted")]
	public uint LocalizedTextIdGiverTextAccepted { get; set; }

	[TableColumn("localizedTextIdReceiverTextAccepted")]
	public uint LocalizedTextIdReceiverTextAccepted { get; set; }

	[TableColumn("localizedTextIdReceiverTextAchieved")]
	public uint LocalizedTextIdReceiverTextAchieved { get; set; }

	[TableColumn("localizedTextIdGiverSayAccepted")]
	public uint LocalizedTextIdGiverSayAccepted { get; set; }

	[TableColumn("localizedTextIdReceiverSayCompleted")]
	public uint LocalizedTextIdReceiverSayCompleted { get; set; }

	[TableColumn("preq_class")]
	public uint PreqClass { get; set; }

	[TableColumn("groupId")]
	public uint GroupId { get; set; }

	[TableColumn("factionIdPreq0")]
	public uint FactionIdPreq0 { get; set; }

	[TableColumn("factionIdPreq01")]
	public uint FactionIdPreq01 { get; set; }

	[TableColumn("factionIdPreq02")]
	public uint FactionIdPreq02 { get; set; }

	[TableColumn("factionLevelPreq0")]
	public uint FactionLevelPreq0 { get; set; }

	[TableColumn("factionLevelPreq01")]
	public uint FactionLevelPreq01 { get; set; }

	[TableColumn("factionLevelPreq02")]
	public uint FactionLevelPreq02 { get; set; }

	[TableColumn("factionLevelCompPreq0")]
	public bool FactionLevelCompPreq0 { get; set; }

	[TableColumn("factionLevelCompPreq01")]
	public bool FactionLevelCompPreq01 { get; set; }

	[TableColumn("factionLevelCompPreq02")]
	public bool FactionLevelCompPreq02 { get; set; }

	[TableColumn("questIdExclusionPreq0")]
	public uint QuestIdExclusionPreq0 { get; set; }

	[TableColumn("questIdExclusionPreq1")]
	public uint QuestIdExclusionPreq1 { get; set; }

	[TableColumn("questIdExclusionPreq2")]
	public uint QuestIdExclusionPreq2 { get; set; }

	[TableColumn("localizedTextIdAcceptResponse")]
	public uint LocalizedTextIdAcceptResponse { get; set; }

	[TableColumn("localizedTextIdCompleteResponse")]
	public uint LocalizedTextIdCompleteResponse { get; set; }

	[TableColumn("WorldLocation2IdReceiver")]
	public uint WorldLocation2IdReceiver { get; set; }

	[TableColumn("worldLocation2IdAltReceiver00")]
	public uint WorldLocation2IdAltReceiver00 { get; set; }

	[TableColumn("worldLocation2IdAltReceiver01")]
	public uint WorldLocation2IdAltReceiver01 { get; set; }

	[TableColumn("worldLocation2IdAltReceiver02")]
	public uint WorldLocation2IdAltReceiver02 { get; set; }

	[TableColumn("prerequisiteIdAltReceiver00")]
	public uint PrerequisiteIdAltReceiver00 { get; set; }

	[TableColumn("prerequisiteIdAltReceiver01")]
	public uint PrerequisiteIdAltReceiver01 { get; set; }

	[TableColumn("prerequisiteIdAltReceiver02")]
	public uint PrerequisiteIdAltReceiver02 { get; set; }

	[TableColumn("questDirectionIdAltReceiver00")]
	public uint QuestDirectionIdAltReceiver00 { get; set; }

	[TableColumn("questDirectionIdAltReceiver01")]
	public uint QuestDirectionIdAltReceiver01 { get; set; }

	[TableColumn("questDirectionIdAltReceiver02")]
	public uint QuestDirectionIdAltReceiver02 { get; set; }

	[TableColumn("localizedTextIdCompletedSummary")]
	public uint LocalizedTextIdCompletedSummary { get; set; }

	[TableColumn("localizedTextIdGiverIncompleteResponse")]
	public uint LocalizedTextIdGiverIncompleteResponse { get; set; }

	[TableColumn("localizedTextIdReceiverIncompleteResponse")]
	public uint LocalizedTextIdReceiverIncompleteResponse { get; set; }

	[TableColumn("quest2DifficultyId")]
	public uint Quest2DifficultyId { get; set; }

	[TableColumn("maxTimeAllowedMS")]
	public uint MaxTimeAllowedMs { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("questShareEnum")]
	public uint QuestShareEnum { get; set; }

	[TableColumn("subMissionPathType")]
	public uint SubMissionPathType { get; set; }

	[TableColumn("localizedTextIdCompletedObjectiveShort")]
	public uint LocalizedTextIdCompletedObjectiveShort { get; set; }

	[TableColumn("quest2SubTypeId")]
	public uint Quest2SubTypeId { get; set; }

	[TableColumn("localizedTextIdMoreInfoSay00")]
	public uint LocalizedTextIdMoreInfoSay00 { get; set; }

	[TableColumn("localizedTextIdMoreInfoSay01")]
	public uint LocalizedTextIdMoreInfoSay01 { get; set; }

	[TableColumn("localizedTextIdMoreInfoSay02")]
	public uint LocalizedTextIdMoreInfoSay02 { get; set; }

	[TableColumn("localizedTextIdMoreInfoSay03")]
	public uint LocalizedTextIdMoreInfoSay03 { get; set; }

	[TableColumn("localizedTextIdMoreInfoSay04")]
	public uint LocalizedTextIdMoreInfoSay04 { get; set; }

	[TableColumn("localizedTextIdMoreInfoText00")]
	public uint LocalizedTextIdMoreInfoText00 { get; set; }

	[TableColumn("localizedTextIdMoreInfoText01")]
	public uint LocalizedTextIdMoreInfoText01 { get; set; }

	[TableColumn("localizedTextIdMoreInfoText02")]
	public uint LocalizedTextIdMoreInfoText02 { get; set; }

	[TableColumn("localizedTextIdMoreInfoText03")]
	public uint LocalizedTextIdMoreInfoText03 { get; set; }

	[TableColumn("localizedTextIdMoreInfoText04")]
	public uint LocalizedTextIdMoreInfoText04 { get; set; }

	[TableColumn("virtualItemIdPushed00")]
	public uint VirtualItemIdPushed00 { get; set; }

	[TableColumn("virtualItemIdPushed01")]
	public uint VirtualItemIdPushed01 { get; set; }

	[TableColumn("virtualItemIdPushed02")]
	public uint VirtualItemIdPushed02 { get; set; }

	[TableColumn("virtualItemIdPushed03")]
	public uint VirtualItemIdPushed03 { get; set; }

	[TableColumn("virtualItemPushedCount00")]
	public uint VirtualItemPushedCount00 { get; set; }

	[TableColumn("virtualItemPushedCount01")]
	public uint VirtualItemPushedCount01 { get; set; }

	[TableColumn("virtualItemPushedCount02")]
	public uint VirtualItemPushedCount02 { get; set; }

	[TableColumn("virtualItemPushedCount03")]
	public uint VirtualItemPushedCount03 { get; set; }

	[TableColumn("virtualItemPushedObjectiveFlagsEnum00")]
	public uint VirtualItemPushedObjectiveFlagsEnum00 { get; set; }

	[TableColumn("virtualItemPushedObjectiveFlagsEnum01")]
	public uint VirtualItemPushedObjectiveFlagsEnum01 { get; set; }

	[TableColumn("virtualItemPushedObjectiveFlagsEnum02")]
	public uint VirtualItemPushedObjectiveFlagsEnum02 { get; set; }

	[TableColumn("virtualItemPushedObjectiveFlagsEnum03")]
	public uint VirtualItemPushedObjectiveFlagsEnum03 { get; set; }

	[TableColumn("questDirectionIdCompletion")]
	public uint QuestDirectionIdCompletion { get; set; }

	[TableColumn("faction2IdRewardReputation00")]
	public uint Faction2IdRewardReputation00 { get; set; }

	[TableColumn("faction2IdRewardReputation01")]
	public uint Faction2IdRewardReputation01 { get; set; }

	[TableColumn("rewardReputationOverride00")]
	public float RewardReputationOverride00 { get; set; }

	[TableColumn("rewardReputationOverride01")]
	public float RewardReputationOverride01 { get; set; }

	[TableColumn("questCategoryId")]
	public uint QuestCategoryId { get; set; }

	[TableColumn("localizedTextIdGiverSayDecline")]
	public uint LocalizedTextIdGiverSayDecline { get; set; }

	[TableColumn("periodicQuestGroupId")]
	public uint PeriodicQuestGroupId { get; set; }

	[TableColumn("periodicQuestWeight")]
	public uint PeriodicQuestWeight { get; set; }

	[TableColumn("questRepeatPeriodEnum")]
	public uint QuestRepeatPeriodEnum { get; set; }

	[TableColumn("questContentFinderTypeEnum")]
	public uint QuestContentFinderTypeEnum { get; set; }

	[TableColumn("groupSize")]
	public uint GroupSize { get; set; }
}
