using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillAchievementLayoutRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("achievementId")]
	public uint AchievementId { get; set; }

	[TableColumn("achievementIdParent00")]
	public uint AchievementIdParent00 { get; set; }

	[TableColumn("achievementIdParent01")]
	public uint AchievementIdParent01 { get; set; }

	[TableColumn("achievementIdParent02")]
	public uint AchievementIdParent02 { get; set; }

	[TableColumn("achievementIdParent03")]
	public uint AchievementIdParent03 { get; set; }

	[TableColumn("achievementIdParent04")]
	public uint AchievementIdParent04 { get; set; }

	[TableColumn("gridX")]
	public uint GridX { get; set; }

	[TableColumn("gridY")]
	public uint GridY { get; set; }
}
