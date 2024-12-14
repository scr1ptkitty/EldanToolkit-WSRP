using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillHarvestingInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("tradeSkillTierId")]
	public uint TradeSkillTierId { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("miniMapMarkerId")]
	public uint MiniMapMarkerId { get; set; }
}
