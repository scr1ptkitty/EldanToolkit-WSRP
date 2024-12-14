using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SalvageExceptionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("item2Id")]
	public uint Item2Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
