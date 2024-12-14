using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillCatalystOrderingRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("unlockLevel00")]
	public uint UnlockLevel00 { get; set; }

	[TableColumn("unlockLevel01")]
	public uint UnlockLevel01 { get; set; }

	[TableColumn("unlockLevel02")]
	public uint UnlockLevel02 { get; set; }

	[TableColumn("unlockLevel03")]
	public uint UnlockLevel03 { get; set; }

	[TableColumn("unlockLevel04")]
	public uint UnlockLevel04 { get; set; }
}
