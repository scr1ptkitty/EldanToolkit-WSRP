using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CurrencyTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("iconName")]
	public string IconName { get; set; } = string.Empty;

	[TableColumn("capAmount")]
	public ulong CapAmount { get; set; }
}
