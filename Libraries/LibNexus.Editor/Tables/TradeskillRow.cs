using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("tutorialId")]
	public uint TutorialId { get; set; }

	[TableColumn("achievementCategoryId")]
	public uint AchievementCategoryId { get; set; }

	[TableColumn("maxAdditives")]
	public uint MaxAdditives { get; set; }

	[TableColumn("localizedTextIdAxisName00")]
	public uint LocalizedTextIdAxisName00 { get; set; }

	[TableColumn("localizedTextIdAxisName01")]
	public uint LocalizedTextIdAxisName01 { get; set; }

	[TableColumn("localizedTextIdAxisName02")]
	public uint LocalizedTextIdAxisName02 { get; set; }

	[TableColumn("localizedTextIdAxisName03")]
	public uint LocalizedTextIdAxisName03 { get; set; }
}
