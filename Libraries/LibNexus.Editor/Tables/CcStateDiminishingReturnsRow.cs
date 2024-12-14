using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CcStateDiminishingReturnsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }
}
