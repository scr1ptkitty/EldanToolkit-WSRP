using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PeriodicQuestSetRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("periodicQuestSetCategoryId")]
	public uint PeriodicQuestSetCategoryId { get; set; }

	[TableColumn("periodicGroupsOffered")]
	public uint PeriodicGroupsOffered { get; set; }

	[TableColumn("weight")]
	public uint Weight { get; set; }
}
