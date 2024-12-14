using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Quest2DifficultyRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("xpMultiplier")]
	public float XpMultiplier { get; set; }

	[TableColumn("cashRewardMultiplier")]
	public float CashRewardMultiplier { get; set; }

	[TableColumn("repRewardMultiplier")]
	public float RepRewardMultiplier { get; set; }
}
