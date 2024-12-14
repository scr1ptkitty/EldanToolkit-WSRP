using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WindRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("type")]
	public uint Type { get; set; }

	[TableColumn("duration")]
	public uint Duration { get; set; }

	[TableColumn("radiusEnd")]
	public float RadiusEnd { get; set; }

	[TableColumn("direction")]
	public float Direction { get; set; }

	[TableColumn("directionDelta")]
	public float DirectionDelta { get; set; }

	[TableColumn("blendIn")]
	public float BlendIn { get; set; }

	[TableColumn("blendOut")]
	public float BlendOut { get; set; }

	[TableColumn("speed")]
	public float Speed { get; set; }

	[TableColumn("sine2DMagnitudeMin")]
	public float Sine2DMagnitudeMin { get; set; }

	[TableColumn("sine2DMagnitudeMax")]
	public float Sine2DMagnitudeMax { get; set; }

	[TableColumn("sine2DFrequency")]
	public float Sine2DFrequency { get; set; }

	[TableColumn("sine2DOffsetAngle")]
	public float Sine2DOffsetAngle { get; set; }

	[TableColumn("localRadial")]
	public uint LocalRadial { get; set; }

	[TableColumn("localMagnitude")]
	public float LocalMagnitude { get; set; }
}
