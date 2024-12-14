using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldSocketRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("worldId")]
	public uint WorldId { get; set; }

	[TableColumn("bounds0")]
	public uint Bounds0 { get; set; }

	[TableColumn("bounds1")]
	public uint Bounds1 { get; set; }

	[TableColumn("bounds2")]
	public uint Bounds2 { get; set; }

	[TableColumn("bounds3")]
	public uint Bounds3 { get; set; }

	[TableColumn("averageHeight")]
	public uint AverageHeight { get; set; }
}
