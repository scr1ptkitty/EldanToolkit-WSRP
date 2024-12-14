using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillCatalystRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("tradeSkillId")]
	public uint TradeSkillId { get; set; }

	[TableColumn("tier")]
	public uint Tier { get; set; }

	[TableColumn("tradeskillCatalystEnum00")]
	public uint TradeskillCatalystEnum00 { get; set; }

	[TableColumn("tradeskillCatalystEnum01")]
	public uint TradeskillCatalystEnum01 { get; set; }

	[TableColumn("tradeskillCatalystEnum02")]
	public uint TradeskillCatalystEnum02 { get; set; }

	[TableColumn("tradeskillCatalystEnum03")]
	public uint TradeskillCatalystEnum03 { get; set; }

	[TableColumn("tradeskillCatalystEnum04")]
	public uint TradeskillCatalystEnum04 { get; set; }

	[TableColumn("value00")]
	public float Value00 { get; set; }

	[TableColumn("value01")]
	public float Value01 { get; set; }

	[TableColumn("value02")]
	public float Value02 { get; set; }

	[TableColumn("value03")]
	public float Value03 { get; set; }

	[TableColumn("value04")]
	public float Value04 { get; set; }
}
