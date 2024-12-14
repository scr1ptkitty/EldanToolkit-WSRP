using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldWaterFogRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("fogStart")]
	public float FogStart { get; set; }

	[TableColumn("fogEnd")]
	public float FogEnd { get; set; }

	[TableColumn("fogStartUW")]
	public float FogStartUw { get; set; }

	[TableColumn("fogEndUW")]
	public float FogEndUw { get; set; }

	[TableColumn("modStart")]
	public float ModStart { get; set; }

	[TableColumn("modEnd")]
	public float ModEnd { get; set; }

	[TableColumn("modStartUW")]
	public float ModStartUw { get; set; }

	[TableColumn("modEndUW")]
	public float ModEndUw { get; set; }

	[TableColumn("skyColorIndex")]
	public uint SkyColorIndex { get; set; }
}
