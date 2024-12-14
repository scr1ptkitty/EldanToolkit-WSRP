using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GenericUnlockSetRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("genericUnlockScopeEnum")]
	public uint GenericUnlockScopeEnum { get; set; }

	[TableColumn("genericUnlockEntryId00")]
	public uint GenericUnlockEntryId00 { get; set; }

	[TableColumn("genericUnlockEntryId01")]
	public uint GenericUnlockEntryId01 { get; set; }

	[TableColumn("genericUnlockEntryId02")]
	public uint GenericUnlockEntryId02 { get; set; }

	[TableColumn("genericUnlockEntryId03")]
	public uint GenericUnlockEntryId03 { get; set; }

	[TableColumn("genericUnlockEntryId04")]
	public uint GenericUnlockEntryId04 { get; set; }

	[TableColumn("genericUnlockEntryId05")]
	public uint GenericUnlockEntryId05 { get; set; }
}
