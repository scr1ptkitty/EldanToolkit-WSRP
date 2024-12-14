using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillTalentTierRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("tradeSkillId")]
	public uint TradeSkillId { get; set; }

	[TableColumn("pointsToUnlock")]
	public uint PointsToUnlock { get; set; }

	[TableColumn("respecCost")]
	public uint RespecCost { get; set; }

	[TableColumn("tradeSkillBonusId00")]
	public uint TradeSkillBonusId00 { get; set; }

	[TableColumn("tradeSkillBonusId01")]
	public uint TradeSkillBonusId01 { get; set; }

	[TableColumn("tradeSkillBonusId02")]
	public uint TradeSkillBonusId02 { get; set; }

	[TableColumn("tradeSkillBonusId03")]
	public uint TradeSkillBonusId03 { get; set; }

	[TableColumn("tradeSkillBonusId04")]
	public uint TradeSkillBonusId04 { get; set; }
}
