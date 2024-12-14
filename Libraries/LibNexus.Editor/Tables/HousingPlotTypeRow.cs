using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingPlotTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("maxPlacedDecor")]
	public uint MaxPlacedDecor { get; set; }
}
