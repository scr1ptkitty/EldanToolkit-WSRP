using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardTrackRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("rewardTrackTypeEnum")]
	public uint RewardTrackTypeEnum { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("localizedTextIdSummary")]
	public uint LocalizedTextIdSummary { get; set; }

	[TableColumn("assetPathImage")]
	public string AssetPathImage { get; set; } = string.Empty;

	[TableColumn("assetPathButtonImage")]
	public string AssetPathButtonImage { get; set; } = string.Empty;

	[TableColumn("rewardPointCost00")]
	public uint RewardPointCost00 { get; set; }

	[TableColumn("rewardPointCost01")]
	public uint RewardPointCost01 { get; set; }

	[TableColumn("rewardPointCost02")]
	public uint RewardPointCost02 { get; set; }

	[TableColumn("rewardPointCost03")]
	public uint RewardPointCost03 { get; set; }

	[TableColumn("rewardPointCost04")]
	public uint RewardPointCost04 { get; set; }

	[TableColumn("rewardPointCost05")]
	public uint RewardPointCost05 { get; set; }

	[TableColumn("rewardPointCost06")]
	public uint RewardPointCost06 { get; set; }

	[TableColumn("rewardPointCost07")]
	public uint RewardPointCost07 { get; set; }

	[TableColumn("rewardPointCost08")]
	public uint RewardPointCost08 { get; set; }

	[TableColumn("rewardPointCost09")]
	public uint RewardPointCost09 { get; set; }

	[TableColumn("rewardTrackIdParent")]
	public uint RewardTrackIdParent { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
