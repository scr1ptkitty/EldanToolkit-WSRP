using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardRotationModifierRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("rewardPropertyId")]
	public uint RewardPropertyId { get; set; }

	[TableColumn("rewardPropertyData")]
	public uint RewardPropertyData { get; set; }

	[TableColumn("value")]
	public float Value { get; set; }

	[TableColumn("minPlayerLevel")]
	public uint MinPlayerLevel { get; set; }

	[TableColumn("worldDifficultyFlags")]
	public uint WorldDifficultyFlags { get; set; }
}
