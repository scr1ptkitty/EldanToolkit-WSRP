using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldLayerRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("Description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("HeightScale")]
	public float HeightScale { get; set; }

	[TableColumn("HeightOffset")]
	public float HeightOffset { get; set; }

	[TableColumn("ParallaxScale")]
	public float ParallaxScale { get; set; }

	[TableColumn("ParallaxOffset")]
	public float ParallaxOffset { get; set; }

	[TableColumn("MetersPerTextureTile")]
	public float MetersPerTextureTile { get; set; }

	[TableColumn("ColorMapPath")]
	public string ColorMapPath { get; set; } = string.Empty;

	[TableColumn("NormalMapPath")]
	public string NormalMapPath { get; set; } = string.Empty;

	[TableColumn("AverageColor")]
	public uint AverageColor { get; set; }

	[TableColumn("Projection")]
	public uint Projection { get; set; }

	[TableColumn("materialType")]
	public uint MaterialType { get; set; }

	[TableColumn("worldClutterId00")]
	public uint WorldClutterId00 { get; set; }

	[TableColumn("worldClutterId01")]
	public uint WorldClutterId01 { get; set; }

	[TableColumn("worldClutterId02")]
	public uint WorldClutterId02 { get; set; }

	[TableColumn("worldClutterId03")]
	public uint WorldClutterId03 { get; set; }

	[TableColumn("specularPower")]
	public float SpecularPower { get; set; }

	[TableColumn("emissiveGlow")]
	public uint EmissiveGlow { get; set; }

	[TableColumn("scrollSpeed00")]
	public float ScrollSpeed00 { get; set; }

	[TableColumn("scrollSpeed01")]
	public float ScrollSpeed01 { get; set; }
}
