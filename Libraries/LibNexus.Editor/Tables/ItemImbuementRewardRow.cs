using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemImbuementRewardRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("itemImbuementRewardTypeEnum")]
	public uint ItemImbuementRewardTypeEnum { get; set; }

	[TableColumn("rewardObjectId")]
	public uint RewardObjectId { get; set; }

	[TableColumn("rewardValue")]
	public uint RewardValue { get; set; }

	[TableColumn("rewardValueFloat")]
	public float RewardValueFloat { get; set; }
}
