using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapContinentRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("assetPath")]
	public string AssetPath { get; set; } = string.Empty;

	[TableColumn("imagePath")]
	public string ImagePath { get; set; } = string.Empty;

	[TableColumn("imageWidth")]
	public uint ImageWidth { get; set; }

	[TableColumn("imageHeight")]
	public uint ImageHeight { get; set; }

	[TableColumn("imageOffsetX")]
	public uint ImageOffsetX { get; set; }

	[TableColumn("imageOffsetY")]
	public uint ImageOffsetY { get; set; }

	[TableColumn("hexMinX")]
	public uint HexMinX { get; set; }

	[TableColumn("hexMinY")]
	public uint HexMinY { get; set; }

	[TableColumn("hexLimX")]
	public uint HexLimX { get; set; }

	[TableColumn("hexLimY")]
	public uint HexLimY { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
