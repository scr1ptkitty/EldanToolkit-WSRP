using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AchievementRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("achievementTypeId")]
	public uint AchievementTypeId { get; set; }

	[TableColumn("achievementCategoryId")]
	public uint AchievementCategoryId { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[TableColumn("localizedTextIdDesc")]
	public uint LocalizedTextIdDesc { get; set; }

	[TableColumn("localizedTextIdProgress")]
	public uint LocalizedTextIdProgress { get; set; }

	[TableColumn("percCompletionToShow")]
	public float PercCompletionToShow { get; set; }

	[TableColumn("objectId")]
	public uint ObjectId { get; set; }

	[TableColumn("objectIdAlt")]
	public uint ObjectIdAlt { get; set; }

	[TableColumn("value")]
	public uint Value { get; set; }

	[TableColumn("characterTitleId")]
	public uint CharacterTitleId { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("prerequisiteIdServer")]
	public uint PrerequisiteIdServer { get; set; }

	[TableColumn("prerequisiteIdObjective")]
	public uint PrerequisiteIdObjective { get; set; }

	[TableColumn("prerequisiteIdObjectiveAlt")]
	public uint PrerequisiteIdObjectiveAlt { get; set; }

	[TableColumn("achievementIdParentTier")]
	public uint AchievementIdParentTier { get; set; }

	[TableColumn("orderIndex")]
	public uint OrderIndex { get; set; }

	[TableColumn("achievementGroupId")]
	public uint AchievementGroupId { get; set; }

	[TableColumn("achievementSubGroupId")]
	public uint AchievementSubGroupId { get; set; }

	[TableColumn("achievementPointEnum")]
	public uint AchievementPointEnum { get; set; }

	[TableColumn("steamAchievementName")]
	public string SteamAchievementName { get; set; } = string.Empty;
}
