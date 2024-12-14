using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelBoneRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("XSIName")]
	public string XsiName { get; set; } = string.Empty;
}
