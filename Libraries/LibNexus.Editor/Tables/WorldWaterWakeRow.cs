using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldWaterWakeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("colorTexture")]
	public string ColorTexture { get; set; } = string.Empty;

	[TableColumn("normalTexture")]
	public string NormalTexture { get; set; } = string.Empty;

	[TableColumn("distortionTexture")]
	public string DistortionTexture { get; set; } = string.Empty;

	[TableColumn("durationMin")]
	public uint DurationMin { get; set; }

	[TableColumn("durationMax")]
	public uint DurationMax { get; set; }

	[TableColumn("scaleStart")]
	public float ScaleStart { get; set; }

	[TableColumn("scaleEnd")]
	public float ScaleEnd { get; set; }

	[TableColumn("alphaStart")]
	public float AlphaStart { get; set; }

	[TableColumn("alphaEnd")]
	public float AlphaEnd { get; set; }

	[TableColumn("distortionWeight")]
	public float DistortionWeight { get; set; }

	[TableColumn("distortionScaleStart")]
	public float DistortionScaleStart { get; set; }

	[TableColumn("distortionScaleEnd")]
	public float DistortionScaleEnd { get; set; }

	[TableColumn("distortionSpeedU")]
	public float DistortionSpeedU { get; set; }

	[TableColumn("distortionSpeedV")]
	public float DistortionSpeedV { get; set; }

	[TableColumn("positionOffsetX")]
	public float PositionOffsetX { get; set; }

	[TableColumn("positionOffsetY")]
	public float PositionOffsetY { get; set; }
}
