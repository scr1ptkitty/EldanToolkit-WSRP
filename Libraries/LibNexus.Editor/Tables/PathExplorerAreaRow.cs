using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerAreaRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("pathSettlerHubId")]
	public uint PathSettlerHubId { get; set; }
}
