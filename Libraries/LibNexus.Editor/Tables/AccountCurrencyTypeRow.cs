using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AccountCurrencyTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("iconName")]
	public string IconName { get; set; } = string.Empty;

	[TableColumn("accountItemId")]
	public uint AccountItemId { get; set; }
}
