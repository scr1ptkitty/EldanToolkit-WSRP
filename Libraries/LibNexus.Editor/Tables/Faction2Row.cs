using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Faction2Row
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("faction2IdParent")]
	public uint Faction2IdParent { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdToolTip")]
	public uint LocalizedTextIdToolTip { get; set; }

	[TableColumn("orderIndex")]
	public uint OrderIndex { get; set; }

	[TableColumn("archiveArticleId")]
	public uint ArchiveArticleId { get; set; }
}
