using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelClusterRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("EnumName")]
	public string EnumName { get; set; } = string.Empty;
}
