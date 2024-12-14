using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4AoeTargetConstraintsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("angle")]
	public float Angle { get; set; }

	[TableColumn("targetCount")]
	public uint TargetCount { get; set; }

	[TableColumn("minRange")]
	public float MinRange { get; set; }

	[TableColumn("maxRange")]
	public float MaxRange { get; set; }

	[TableColumn("targetSelection")]
	public uint TargetSelection { get; set; }
}
