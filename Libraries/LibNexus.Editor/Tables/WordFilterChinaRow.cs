using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WordFilterChinaRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("filter")]
	public string Filter { get; set; } = string.Empty;
}
