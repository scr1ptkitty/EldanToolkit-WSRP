using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingPlotInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("worldSocketId")]
	public uint WorldSocketId { get; set; }

	[TableColumn("plotType")]
	public uint PlotType { get; set; }

	[TableColumn("housingPropertyInfoId")]
	public uint HousingPropertyInfoId { get; set; }

	[TableColumn("housingPropertyPlotIndex")]
	public uint HousingPropertyPlotIndex { get; set; }

	[TableColumn("housingPlugItemIdDefault")]
	public uint HousingPlugItemIdDefault { get; set; }
}
