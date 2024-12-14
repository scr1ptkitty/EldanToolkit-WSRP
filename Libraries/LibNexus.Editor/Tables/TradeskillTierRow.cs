using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillTierRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("tradeSkillId")]
	public uint TradeSkillId { get; set; }

	[TableColumn("tier")]
	public uint Tier { get; set; }

	[TableColumn("requiredXp")]
	public uint RequiredXp { get; set; }

	[TableColumn("learnXp")]
	public uint LearnXp { get; set; }

	[TableColumn("craftXp")]
	public uint CraftXp { get; set; }

	[TableColumn("firstCraftXp")]
	public uint FirstCraftXp { get; set; }

	[TableColumn("questXp")]
	public uint QuestXp { get; set; }

	[TableColumn("failXp")]
	public uint FailXp { get; set; }

	[TableColumn("itemLevelMin")]
	public uint ItemLevelMin { get; set; }

	[TableColumn("maxAdditives")]
	public uint MaxAdditives { get; set; }

	[TableColumn("relearnCost")]
	public ulong RelearnCost { get; set; }

	[TableColumn("achievementCategoryId")]
	public uint AchievementCategoryId { get; set; }
}
