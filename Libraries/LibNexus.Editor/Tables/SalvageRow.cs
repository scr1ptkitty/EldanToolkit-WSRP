using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SalvageRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("item2TypeId")]
	public uint Item2TypeId { get; set; }

	[TableColumn("level")]
	public uint Level { get; set; }
}
