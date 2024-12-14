using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class InstancePortalRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("minLevel")]
	public uint MinLevel { get; set; }

	[TableColumn("maxLevel")]
	public uint MaxLevel { get; set; }

	[TableColumn("expectedCompletionTime")]
	public uint ExpectedCompletionTime { get; set; }

	[TableColumn("instancePortalTypeEnum")]
	public uint InstancePortalTypeEnum { get; set; }
}
