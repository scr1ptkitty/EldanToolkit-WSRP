using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class DyeColorRampRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("rampIndex")]
	public uint RampIndex { get; set; }

	[TableColumn("costMultiplier")]
	public float CostMultiplier { get; set; }

	[TableColumn("componentMapEnum")]
	public uint ComponentMapEnum { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
