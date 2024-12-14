using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spline2NodeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("splineId")]
	public uint SplineId { get; set; }

	[TableColumn("ordinal")]
	public uint Ordinal { get; set; }

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

	[TableColumn("eventId")]
	public uint EventId { get; set; }

	[TableColumn("frameTime")]
	public float FrameTime { get; set; }

	[TableColumn("delay")]
	public float Delay { get; set; }

	[TableColumn("fovy")]
	public float Fovy { get; set; }
}
