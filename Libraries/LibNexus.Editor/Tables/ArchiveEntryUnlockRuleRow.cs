using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ArchiveEntryUnlockRuleRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("archiveEntryId")]
	public uint ArchiveEntryId { get; set; }

	[TableColumn("archiveEntryUnlockRuleEnum")]
	public uint ArchiveEntryUnlockRuleEnum { get; set; }

	[TableColumn("archiveEntryUnlockRuleFlags")]
	public uint ArchiveEntryUnlockRuleFlags { get; set; }

	[TableColumn("object00")]
	public uint Object00 { get; set; }

	[TableColumn("object01")]
	public uint Object01 { get; set; }

	[TableColumn("object02")]
	public uint Object02 { get; set; }

	[TableColumn("object03")]
	public uint Object03 { get; set; }

	[TableColumn("object04")]
	public uint Object04 { get; set; }

	[TableColumn("object05")]
	public uint Object05 { get; set; }
}
