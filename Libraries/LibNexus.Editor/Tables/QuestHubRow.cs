using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class QuestHubRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }
}
