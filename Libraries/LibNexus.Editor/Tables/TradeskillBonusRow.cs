using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillBonusRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("tradeSkillTierId")]
	public uint TradeSkillTierId { get; set; }

	[TableColumn("achievementId")]
	public uint AchievementId { get; set; }

	[TableColumn("iconPath")]
	public string IconPath { get; set; } = string.Empty;

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[TableColumn("tradeskillBonusEnum00")]
	public uint TradeskillBonusEnum00 { get; set; }

	[TableColumn("tradeskillBonusEnum01")]
	public uint TradeskillBonusEnum01 { get; set; }

	[TableColumn("tradeskillBonusEnum02")]
	public uint TradeskillBonusEnum02 { get; set; }

	[TableColumn("objectIdPrimary00")]
	public uint ObjectIdPrimary00 { get; set; }

	[TableColumn("objectIdPrimary01")]
	public uint ObjectIdPrimary01 { get; set; }

	[TableColumn("objectIdPrimary02")]
	public uint ObjectIdPrimary02 { get; set; }

	[TableColumn("objectIdSecondary00")]
	public uint ObjectIdSecondary00 { get; set; }

	[TableColumn("objectIdSecondary01")]
	public uint ObjectIdSecondary01 { get; set; }

	[TableColumn("objectIdSecondary02")]
	public uint ObjectIdSecondary02 { get; set; }

	[TableColumn("objectIdTertiary00")]
	public uint ObjectIdTertiary00 { get; set; }

	[TableColumn("objectIdTertiary01")]
	public uint ObjectIdTertiary01 { get; set; }

	[TableColumn("objectIdTertiary02")]
	public uint ObjectIdTertiary02 { get; set; }

	[TableColumn("value00")]
	public float Value00 { get; set; }

	[TableColumn("value01")]
	public float Value01 { get; set; }

	[TableColumn("value02")]
	public float Value02 { get; set; }

	[TableColumn("valueInt00")]
	public uint ValueInt00 { get; set; }

	[TableColumn("valueInt01")]
	public uint ValueInt01 { get; set; }

	[TableColumn("valueInt02")]
	public uint ValueInt02 { get; set; }
}
