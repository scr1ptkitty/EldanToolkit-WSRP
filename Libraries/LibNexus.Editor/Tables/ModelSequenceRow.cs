using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelSequenceRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("FallBackID")]
	public uint FallBackId { get; set; }

	[TableColumn("flag")]
	public uint Flag { get; set; }
}
