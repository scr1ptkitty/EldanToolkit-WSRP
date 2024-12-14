using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemBudgetRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("budget00")]
	public float Budget00 { get; set; }

	[TableColumn("budget01")]
	public float Budget01 { get; set; }

	[TableColumn("budget02")]
	public float Budget02 { get; set; }

	[TableColumn("budget03")]
	public float Budget03 { get; set; }

	[TableColumn("budget04")]
	public float Budget04 { get; set; }
}
