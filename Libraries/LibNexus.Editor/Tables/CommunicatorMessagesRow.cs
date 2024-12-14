using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CommunicatorMessagesRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdMessage")]
	public uint LocalizedTextIdMessage { get; set; }

	[TableColumn("delay")]
	public uint Delay { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("creatureId")]
	public uint CreatureId { get; set; }

	[TableColumn("worldId")]
	public uint WorldId { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("minLevel")]
	public uint MinLevel { get; set; }

	[TableColumn("maxLevel")]
	public uint MaxLevel { get; set; }

	[TableColumn("quest00")]
	public uint Quest00 { get; set; }

	[TableColumn("quest01")]
	public uint Quest01 { get; set; }

	[TableColumn("quest02")]
	public uint Quest02 { get; set; }

	[TableColumn("state00")]
	public uint State00 { get; set; }

	[TableColumn("state01")]
	public uint State01 { get; set; }

	[TableColumn("state02")]
	public uint State02 { get; set; }

	[TableColumn("factionId")]
	public uint FactionId { get; set; }

	[TableColumn("classId")]
	public uint ClassId { get; set; }

	[TableColumn("raceId")]
	public uint RaceId { get; set; }

	[TableColumn("factionIdReputation")]
	public uint FactionIdReputation { get; set; }

	[TableColumn("reputationMin")]
	public uint ReputationMin { get; set; }

	[TableColumn("reputationMax")]
	public uint ReputationMax { get; set; }

	[TableColumn("questIdDelivered")]
	public uint QuestIdDelivered { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("displayDuration")]
	public uint DisplayDuration { get; set; }

	[TableColumn("communicatorMessagesIdNext")]
	public uint CommunicatorMessagesIdNext { get; set; }

	[TableColumn("communicatorPortraitPlacementEnum")]
	public uint CommunicatorPortraitPlacementEnum { get; set; }

	[TableColumn("communicatorOverlayEnum")]
	public uint CommunicatorOverlayEnum { get; set; }

	[TableColumn("communicatorBackgroundEnum")]
	public uint CommunicatorBackgroundEnum { get; set; }
}
