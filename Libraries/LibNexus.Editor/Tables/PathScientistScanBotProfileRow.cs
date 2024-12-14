using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathScientistScanBotProfileRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("creature2Id")]
	public uint Creature2Id { get; set; }

	[TableColumn("scanTimeMS")]
	public uint ScanTimeMs { get; set; }

	[TableColumn("processingTimeMS")]
	public uint ProcessingTimeMs { get; set; }

	[TableColumn("playerRadius")]
	public float PlayerRadius { get; set; }

	[TableColumn("scanAOERange")]
	public float ScanAoeRange { get; set; }

	[TableColumn("maxSeekDistance")]
	public float MaxSeekDistance { get; set; }

	[TableColumn("speedMultiplier")]
	public float SpeedMultiplier { get; set; }

	[TableColumn("thoroughnessMultiplier")]
	public float ThoroughnessMultiplier { get; set; }

	[TableColumn("healthMultiplier")]
	public float HealthMultiplier { get; set; }

	[TableColumn("healthRegenMultiplier")]
	public float HealthRegenMultiplier { get; set; }

	[TableColumn("minCooldownTimeMs")]
	public uint MinCooldownTimeMs { get; set; }

	[TableColumn("maxCooldownTimeMs")]
	public uint MaxCooldownTimeMs { get; set; }

	[TableColumn("maxCooldownDistance")]
	public float MaxCooldownDistance { get; set; }

	[TableColumn("pathScientistScanBotProfileFlags")]
	public uint PathScientistScanBotProfileFlags { get; set; }

	[TableColumn("socketCount")]
	public uint SocketCount { get; set; }
}
