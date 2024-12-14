using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AchievementCategoryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("localizedTextIdFullName")]
	public uint LocalizedTextIdFullName { get; set; }

	[TableColumn("achievementCategoryIdParent")]
	public uint AchievementCategoryIdParent { get; set; }
}
