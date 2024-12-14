using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4CcConditionsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("ccStateMask")]
	public uint CcStateMask { get; set; }

	[TableColumn("ccStateFlagsRequired")]
	public uint CcStateFlagsRequired { get; set; }
}
