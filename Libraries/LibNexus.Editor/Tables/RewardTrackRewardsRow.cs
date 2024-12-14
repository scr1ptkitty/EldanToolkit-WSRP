using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardTrackRewardsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("rewardTrackId")]
	public uint RewardTrackId { get; set; }

	[TableColumn("rewardPointFlags")]
	public uint RewardPointFlags { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("currencyTypeId")]
	public uint CurrencyTypeId { get; set; }

	[TableColumn("currencyAmount")]
	public uint CurrencyAmount { get; set; }

	[TableColumn("rewardTrackRewardTypeEnum00")]
	public uint RewardTrackRewardTypeEnum00 { get; set; }

	[TableColumn("rewardTrackRewardTypeEnum01")]
	public uint RewardTrackRewardTypeEnum01 { get; set; }

	[TableColumn("rewardTrackRewardTypeEnum02")]
	public uint RewardTrackRewardTypeEnum02 { get; set; }

	[TableColumn("rewardChoiceId00")]
	public uint RewardChoiceId00 { get; set; }

	[TableColumn("rewardChoiceId01")]
	public uint RewardChoiceId01 { get; set; }

	[TableColumn("rewardChoiceId02")]
	public uint RewardChoiceId02 { get; set; }

	[TableColumn("rewardChoiceCount00")]
	public uint RewardChoiceCount00 { get; set; }

	[TableColumn("rewardChoiceCount01")]
	public uint RewardChoiceCount01 { get; set; }

	[TableColumn("rewardChoiceCount02")]
	public uint RewardChoiceCount02 { get; set; }
}
