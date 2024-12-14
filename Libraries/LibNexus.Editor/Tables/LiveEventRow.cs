using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LiveEventRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("liveEventTypeEnum")]
	public uint LiveEventTypeEnum { get; set; }

	[TableColumn("maxValue")]
	public uint MaxValue { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("liveEventCategoryEnum")]
	public uint LiveEventCategoryEnum { get; set; }

	[TableColumn("liveEventIdParent")]
	public uint LiveEventIdParent { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdSummary")]
	public uint LocalizedTextIdSummary { get; set; }

	[TableColumn("iconPath")]
	public string IconPath { get; set; } = string.Empty;

	[TableColumn("iconPathButton")]
	public string IconPathButton { get; set; } = string.Empty;

	[TableColumn("spritePathTitle")]
	public string SpritePathTitle { get; set; } = string.Empty;

	[TableColumn("spritePathBackground")]
	public string SpritePathBackground { get; set; } = string.Empty;

	[TableColumn("currencyTypeIdEarned")]
	public uint CurrencyTypeIdEarned { get; set; }

	[TableColumn("localizedTextIdCurrencyEarnedTooltip")]
	public uint LocalizedTextIdCurrencyEarnedTooltip { get; set; }

	[TableColumn("worldLocation2IdExile")]
	public uint WorldLocation2IdExile { get; set; }

	[TableColumn("worldLocation2IdDominion")]
	public uint WorldLocation2IdDominion { get; set; }
}
