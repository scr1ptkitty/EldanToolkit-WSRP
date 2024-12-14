using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSoldierEventRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("pathSoldierEventType")]
	public uint PathSoldierEventType { get; set; }

	[TableColumn("maxTimeBetweenWaves")]
	public uint MaxTimeBetweenWaves { get; set; }

	[TableColumn("maxEventTime")]
	public uint MaxEventTime { get; set; }

	[TableColumn("towerDefenseAllowance")]
	public uint TowerDefenseAllowance { get; set; }

	[TableColumn("towerDefenseBuildTimeMS")]
	public uint TowerDefenseBuildTimeMs { get; set; }

	[TableColumn("initialSpawnTime")]
	public uint InitialSpawnTime { get; set; }
}
