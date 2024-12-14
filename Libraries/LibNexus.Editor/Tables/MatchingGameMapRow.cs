using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MatchingGameMapRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("matchingGameMapEnumFlags")]
	public uint MatchingGameMapEnumFlags { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("matchingGameTypeId")]
	public uint MatchingGameTypeId { get; set; }

	[TableColumn("worldId")]
	public uint WorldId { get; set; }

	[TableColumn("recommendedItemLevel")]
	public uint RecommendedItemLevel { get; set; }

	[TableColumn("achievementCategoryId")]
	public uint AchievementCategoryId { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
