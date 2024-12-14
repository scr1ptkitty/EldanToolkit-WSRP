using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PeriodicQuestSetCategoryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("periodicSetsOffered")]
	public uint PeriodicSetsOffered { get; set; }
}
