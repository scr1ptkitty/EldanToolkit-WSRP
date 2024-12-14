using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4ConditionsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("conditionMask")]
	public uint ConditionMask { get; set; }

	[TableColumn("conditionValue")]
	public uint ConditionValue { get; set; }
}
