using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSoldierTowerDefenseRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("pathSoldierEventId")]
	public uint PathSoldierEventId { get; set; }

	[TableColumn("buildCost")]
	public uint BuildCost { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("worldLocation2IdDisplay")]
	public uint WorldLocation2IdDisplay { get; set; }

	[TableColumn("towerDefenseBuildType")]
	public uint TowerDefenseBuildType { get; set; }

	[TableColumn("spell4Id")]
	public uint Spell4Id { get; set; }

	[TableColumn("soldierTowerDefenseFlags")]
	public uint SoldierTowerDefenseFlags { get; set; }

	[TableColumn("soldierTowerDefenseImprovementType")]
	public uint SoldierTowerDefenseImprovementType { get; set; }
}
