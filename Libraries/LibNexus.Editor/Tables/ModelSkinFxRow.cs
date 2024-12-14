using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelSkinFxRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("suffix")]
	public string Suffix { get; set; } = string.Empty;
}
