using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardPropertyRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("rewardModifierValueTypeEnum")]
	public uint RewardModifierValueTypeEnum { get; set; }
}
