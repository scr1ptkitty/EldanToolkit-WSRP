using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillAdditiveRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("tradeSkillId")]
	public uint TradeSkillId { get; set; }

	[TableColumn("tier")]
	public uint Tier { get; set; }

	[TableColumn("vectorX")]
	public float VectorX { get; set; }

	[TableColumn("vectorY")]
	public float VectorY { get; set; }

	[TableColumn("radius")]
	public float Radius { get; set; }
}
