using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TutorialLayoutRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("form")]
	public string Form { get; set; } = string.Empty;

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
