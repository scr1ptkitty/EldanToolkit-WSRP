using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PrerequisiteTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdError")]
	public uint LocalizedTextIdError { get; set; }
}
