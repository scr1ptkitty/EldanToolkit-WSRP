using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LocalizedEnumRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
