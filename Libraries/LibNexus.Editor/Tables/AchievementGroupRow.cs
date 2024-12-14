using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AchievementGroupRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("tradeSkillId")]
	public uint TradeSkillId { get; set; }
}
