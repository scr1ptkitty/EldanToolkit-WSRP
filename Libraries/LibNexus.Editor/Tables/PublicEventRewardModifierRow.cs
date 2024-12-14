using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventRewardModifierRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("publicEventId")]
	public uint PublicEventId { get; set; }

	[TableColumn("rewardPropertyId")]
	public uint RewardPropertyId { get; set; }

	[TableColumn("data")]
	public uint Data { get; set; }

	[TableColumn("offset")]
	public float Offset { get; set; }
}
