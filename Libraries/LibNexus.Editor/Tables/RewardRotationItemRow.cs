using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardRotationItemRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("rewardItemTypeEnum")]
	public uint RewardItemTypeEnum { get; set; }

	[TableColumn("rewardItemObject")]
	public uint RewardItemObject { get; set; }

	[TableColumn("count")]
	public uint Count { get; set; }

	[TableColumn("iconPath")]
	public string IconPath { get; set; } = string.Empty;

	[TableColumn("minPlayerLevel")]
	public uint MinPlayerLevel { get; set; }

	[TableColumn("worldDifficultyFlags")]
	public uint WorldDifficultyFlags { get; set; }
}
