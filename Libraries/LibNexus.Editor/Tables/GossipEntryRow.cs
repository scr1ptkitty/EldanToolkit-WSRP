using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GossipEntryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("gossipSetId")]
	public uint GossipSetId { get; set; }

	[TableColumn("indexOrder")]
	public uint IndexOrder { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
