using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class DailyLoginRewardRow
{
	[TableColumn("id")]
	public uint Id { get; set; }

	[TableColumn("loginDay")]
	public uint LoginDay { get; set; }

	[TableColumn("dailyLoginRewardTypeEnum")]
	public uint DailyLoginRewardTypeEnum { get; set; }

	[TableColumn("rewardObjectValue")]
	public uint RewardObjectValue { get; set; }

	[TableColumn("dailyLoginRewardTierEnum")]
	public uint DailyLoginRewardTierEnum { get; set; }
}
