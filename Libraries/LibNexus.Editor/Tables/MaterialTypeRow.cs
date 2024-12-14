using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MaterialTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("MaterialFlags")]
	public uint MaterialFlags { get; set; }
}
