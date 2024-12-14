using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TaxiRouteRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("taxiNodeIdSource")]
	public uint TaxiNodeIdSource { get; set; }

	[TableColumn("taxiNodeIdDestination")]
	public uint TaxiNodeIdDestination { get; set; }

	[TableColumn("price")]
	public uint Price { get; set; }
}
