using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldLocation2Row
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("radius")]
	public float Radius { get; set; }

	[TableColumn("maxVerticalDistance")]
	public float MaxVerticalDistance { get; set; }

	[TableColumn("position0")]
	public float Position0 { get; set; }

	[TableColumn("position1")]
	public float Position1 { get; set; }

	[TableColumn("position2")]
	public float Position2 { get; set; }

	[TableColumn("facing0")]
	public float Facing0 { get; set; }

	[TableColumn("facing1")]
	public float Facing1 { get; set; }

	[TableColumn("facing2")]
	public float Facing2 { get; set; }

	[TableColumn("facing3")]
	public float Facing3 { get; set; }

	[TableColumn("worldId")]
	public uint WorldId { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("phases")]
	public uint Phases { get; set; }
}
