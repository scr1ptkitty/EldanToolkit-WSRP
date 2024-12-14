using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class VitalRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdDisplayText")]
	public uint LocalizedTextIdDisplayText { get; set; }
}
