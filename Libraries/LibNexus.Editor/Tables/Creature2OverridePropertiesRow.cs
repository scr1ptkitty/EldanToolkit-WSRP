using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2OverridePropertiesRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("creature2Id")]
	public uint Creature2Id { get; set; }

	[TableColumn("unitPropertyIndex")]
	public uint UnitPropertyIndex { get; set; }

	[TableColumn("unitPropertyValue")]
	public float UnitPropertyValue { get; set; }
}
