using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4TargetAngleRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("targetAngle")]
	public float TargetAngle { get; set; }
}
