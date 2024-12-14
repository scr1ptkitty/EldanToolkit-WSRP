using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4HitResultsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
