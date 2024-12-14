using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Quest2RewardRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("quest2Id")]
	public uint Quest2Id { get; set; }

	[TableColumn("quest2RewardTypeId")]
	public uint Quest2RewardTypeId { get; set; }

	[TableColumn("objectId")]
	public uint ObjectId { get; set; }

	[TableColumn("objectAmount")]
	public uint ObjectAmount { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
