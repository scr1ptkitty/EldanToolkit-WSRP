using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TicketCategoryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
