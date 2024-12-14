using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldSkyRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("assetPath")]
	public string AssetPath { get; set; } = string.Empty;

	[TableColumn("assetPathInFlux")]
	public string AssetPathInFlux { get; set; } = string.Empty;

	[TableColumn("color")]
	public uint Color { get; set; }
}
