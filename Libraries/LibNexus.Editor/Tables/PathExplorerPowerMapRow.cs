using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerPowerMapRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("distanceThreshold")]
	public uint DistanceThreshold { get; set; }

	[TableColumn("collectQuantity")]
	public uint CollectQuantity { get; set; }

	[TableColumn("victoryPauseMS")]
	public uint VictoryPauseMs { get; set; }

	[TableColumn("worldLocation2IdVisual")]
	public uint WorldLocation2IdVisual { get; set; }

	[TableColumn("visualEffectIdInactive")]
	public uint VisualEffectIdInactive { get; set; }

	[TableColumn("localizedTextIdInfo")]
	public uint LocalizedTextIdInfo { get; set; }
}
