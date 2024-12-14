using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ChallengeTierRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("count")]
	public uint Count { get; set; }
}
