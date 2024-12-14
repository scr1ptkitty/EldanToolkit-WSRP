using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PrimalMatrixRewardRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("primalMatrixRewardTypeEnum0")]
	public uint PrimalMatrixRewardTypeEnum0 { get; set; }

	[TableColumn("primalMatrixRewardTypeEnum1")]
	public uint PrimalMatrixRewardTypeEnum1 { get; set; }

	[TableColumn("primalMatrixRewardTypeEnum2")]
	public uint PrimalMatrixRewardTypeEnum2 { get; set; }

	[TableColumn("primalMatrixRewardTypeEnum3")]
	public uint PrimalMatrixRewardTypeEnum3 { get; set; }

	[TableColumn("objectId0")]
	public uint ObjectId0 { get; set; }

	[TableColumn("objectId1")]
	public uint ObjectId1 { get; set; }

	[TableColumn("objectId2")]
	public uint ObjectId2 { get; set; }

	[TableColumn("objectId3")]
	public uint ObjectId3 { get; set; }

	[TableColumn("subObjectId0")]
	public uint SubObjectId0 { get; set; }

	[TableColumn("subObjectId1")]
	public uint SubObjectId1 { get; set; }

	[TableColumn("subObjectId2")]
	public uint SubObjectId2 { get; set; }

	[TableColumn("subObjectId3")]
	public uint SubObjectId3 { get; set; }

	[TableColumn("value0")]
	public float Value0 { get; set; }

	[TableColumn("value1")]
	public float Value1 { get; set; }

	[TableColumn("value2")]
	public float Value2 { get; set; }

	[TableColumn("value3")]
	public float Value3 { get; set; }
}
