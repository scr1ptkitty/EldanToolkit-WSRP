using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HookAssetRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("asset")]
	public string Asset { get; set; } = string.Empty;

	[TableColumn("scale")]
	public float Scale { get; set; }

	[TableColumn("offsetX")]
	public float OffsetX { get; set; }

	[TableColumn("offsetY")]
	public float OffsetY { get; set; }

	[TableColumn("offsetZ")]
	public float OffsetZ { get; set; }

	[TableColumn("rotationX")]
	public float RotationX { get; set; }

	[TableColumn("rotationY")]
	public float RotationY { get; set; }

	[TableColumn("rotationZ")]
	public float RotationZ { get; set; }
}
