using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class BindPointRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("bindPointFactionEnum")]
	public uint BindPointFactionEnum { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
