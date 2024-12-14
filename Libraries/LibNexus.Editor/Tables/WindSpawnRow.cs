using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WindSpawnRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("intervalMin")]
	public uint IntervalMin { get; set; }

	[TableColumn("intervalMax")]
	public uint IntervalMax { get; set; }

	[TableColumn("directionMin")]
	public float DirectionMin { get; set; }

	[TableColumn("directionMax")]
	public float DirectionMax { get; set; }
}
