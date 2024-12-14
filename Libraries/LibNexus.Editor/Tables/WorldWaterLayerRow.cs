using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldWaterLayerRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("RippleColorTex")]
	public string RippleColorTex { get; set; } = string.Empty;

	[TableColumn("RippleNormalTex")]
	public string RippleNormalTex { get; set; } = string.Empty;

	[TableColumn("Scale")]
	public float Scale { get; set; }

	[TableColumn("Rotation")]
	public float Rotation { get; set; }

	[TableColumn("Speed")]
	public float Speed { get; set; }

	[TableColumn("OscFrequency")]
	public float OscFrequency { get; set; }

	[TableColumn("OscMagnitude")]
	public float OscMagnitude { get; set; }

	[TableColumn("OscRotation")]
	public float OscRotation { get; set; }

	[TableColumn("OscPhase")]
	public float OscPhase { get; set; }

	[TableColumn("OscMinLayerWeight")]
	public float OscMinLayerWeight { get; set; }

	[TableColumn("OscMaxLayerWeight")]
	public float OscMaxLayerWeight { get; set; }

	[TableColumn("OscLayerWeightPhase")]
	public float OscLayerWeightPhase { get; set; }

	[TableColumn("materialBlend")]
	public float MaterialBlend { get; set; }
}
