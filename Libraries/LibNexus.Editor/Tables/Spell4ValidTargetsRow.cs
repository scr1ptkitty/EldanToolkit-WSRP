using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4ValidTargetsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("targetBitmask")]
	public uint TargetBitmask { get; set; }
}
