using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillAchievementRewardRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("achievementId")]
	public uint AchievementId { get; set; }

	[TableColumn("faction2Id")]
	public uint Faction2Id { get; set; }

	[TableColumn("factionIdAmount")]
	public uint FactionIdAmount { get; set; }

	[TableColumn("talentPoints")]
	public uint TalentPoints { get; set; }

	[TableColumn("tradeSkillSchematicId00")]
	public uint TradeSkillSchematicId00 { get; set; }

	[TableColumn("tradeSkillSchematicId01")]
	public uint TradeSkillSchematicId01 { get; set; }

	[TableColumn("tradeSkillSchematicId02")]
	public uint TradeSkillSchematicId02 { get; set; }

	[TableColumn("tradeSkillSchematicId03")]
	public uint TradeSkillSchematicId03 { get; set; }

	[TableColumn("tradeSkillSchematicId04")]
	public uint TradeSkillSchematicId04 { get; set; }

	[TableColumn("tradeSkillSchematicId05")]
	public uint TradeSkillSchematicId05 { get; set; }

	[TableColumn("tradeSkillSchematicId06")]
	public uint TradeSkillSchematicId06 { get; set; }

	[TableColumn("tradeSkillSchematicId07")]
	public uint TradeSkillSchematicId07 { get; set; }
}
