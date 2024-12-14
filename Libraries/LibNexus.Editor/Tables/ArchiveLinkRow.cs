using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ArchiveLinkRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("archiveArticleIdParent")]
	public uint ArchiveArticleIdParent { get; set; }

	[TableColumn("archiveArticleIdChild")]
	public uint ArchiveArticleIdChild { get; set; }

	[TableColumn("archiveLinkFlags")]
	public uint ArchiveLinkFlags { get; set; }
}
