using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MissileRevolverTrackRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("radius")]
	public float Radius { get; set; }

	[TableColumn("speed")]
	public float Speed { get; set; }

	[TableColumn("speedMultiplier")]
	public float SpeedMultiplier { get; set; }

	[TableColumn("scaleMultiplier")]
	public float ScaleMultiplier { get; set; }

	[TableColumn("modelAttachmentIdHeight")]
	public uint ModelAttachmentIdHeight { get; set; }
}
