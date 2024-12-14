using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4TargetMechanicsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("targetType")]
	public uint TargetType { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
