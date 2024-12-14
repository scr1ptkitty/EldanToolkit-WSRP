using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ComponentRegionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("EnumName")]
	public string EnumName { get; set; } = string.Empty;

	[TableColumn("componentMap")]
	public uint ComponentMap { get; set; }
}
