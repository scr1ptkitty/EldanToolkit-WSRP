using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathMissionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("creature2IdUnlock")]
	public uint Creature2IdUnlock { get; set; }

	[TableColumn("pathTypeEnum")]
	public uint PathTypeEnum { get; set; }

	[TableColumn("pathMissionTypeEnum")]
	public uint PathMissionTypeEnum { get; set; }

	[TableColumn("pathMissionDisplayTypeEnum")]
	public uint PathMissionDisplayTypeEnum { get; set; }

	[TableColumn("objectId")]
	public uint ObjectId { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdSummary")]
	public uint LocalizedTextIdSummary { get; set; }

	[TableColumn("pathEpisodeId")]
	public uint PathEpisodeId { get; set; }

	[TableColumn("worldLocation2Id00")]
	public uint WorldLocation2Id00 { get; set; }

	[TableColumn("worldLocation2Id01")]
	public uint WorldLocation2Id01 { get; set; }

	[TableColumn("worldLocation2Id02")]
	public uint WorldLocation2Id02 { get; set; }

	[TableColumn("worldLocation2Id03")]
	public uint WorldLocation2Id03 { get; set; }

	[TableColumn("pathMissionFlags")]
	public uint PathMissionFlags { get; set; }

	[TableColumn("pathMissionFactionEnum")]
	public uint PathMissionFactionEnum { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("localizedTextIdCommunicator")]
	public uint LocalizedTextIdCommunicator { get; set; }

	[TableColumn("localizedTextIdUnlock")]
	public uint LocalizedTextIdUnlock { get; set; }

	[TableColumn("localizedTextIdSoldierOrders")]
	public uint LocalizedTextIdSoldierOrders { get; set; }

	[TableColumn("creature2IdContactOverride")]
	public uint Creature2IdContactOverride { get; set; }

	[TableColumn("questDirectionId")]
	public uint QuestDirectionId { get; set; }
}
