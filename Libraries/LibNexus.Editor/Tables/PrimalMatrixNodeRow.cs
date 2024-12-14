using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PrimalMatrixNodeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("positionX")]
	public uint PositionX { get; set; }

	[TableColumn("positionY")]
	public uint PositionY { get; set; }

	[TableColumn("primalMatrixNodeTypeEnum")]
	public uint PrimalMatrixNodeTypeEnum { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("maxAllocations")]
	public uint MaxAllocations { get; set; }

	[TableColumn("costRedEssence")]
	public uint CostRedEssence { get; set; }

	[TableColumn("costBlueEssence")]
	public uint CostBlueEssence { get; set; }

	[TableColumn("costGreenEssence")]
	public uint CostGreenEssence { get; set; }

	[TableColumn("costPurpleEssence")]
	public uint CostPurpleEssence { get; set; }

	[TableColumn("primalMatrixRewardIdWarrior")]
	public uint PrimalMatrixRewardIdWarrior { get; set; }

	[TableColumn("primalMatrixRewardIdEngineer")]
	public uint PrimalMatrixRewardIdEngineer { get; set; }

	[TableColumn("primalMatrixRewardIdEsper")]
	public uint PrimalMatrixRewardIdEsper { get; set; }

	[TableColumn("primalMatrixRewardIdMedic")]
	public uint PrimalMatrixRewardIdMedic { get; set; }

	[TableColumn("primalMatrixRewardIdStalker")]
	public uint PrimalMatrixRewardIdStalker { get; set; }

	[TableColumn("primalMatrixRewardIdSpellslinger")]
	public uint PrimalMatrixRewardIdSpellslinger { get; set; }
}
