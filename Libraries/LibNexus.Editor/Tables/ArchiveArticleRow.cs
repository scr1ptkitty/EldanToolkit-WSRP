using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ArchiveArticleRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("creature2IdPortrait")]
	public uint Creature2IdPortrait { get; set; }

	[TableColumn("iconAssetPath")]
	public string IconAssetPath { get; set; } = string.Empty;

	[TableColumn("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[TableColumn("localizedTextIdText00")]
	public uint LocalizedTextIdText00 { get; set; }

	[TableColumn("localizedTextIdText01")]
	public uint LocalizedTextIdText01 { get; set; }

	[TableColumn("localizedTextIdText02")]
	public uint LocalizedTextIdText02 { get; set; }

	[TableColumn("localizedTextIdText03")]
	public uint LocalizedTextIdText03 { get; set; }

	[TableColumn("localizedTextIdText04")]
	public uint LocalizedTextIdText04 { get; set; }

	[TableColumn("localizedTextIdText05")]
	public uint LocalizedTextIdText05 { get; set; }

	[TableColumn("archiveEntryId00")]
	public uint ArchiveEntryId00 { get; set; }

	[TableColumn("archiveEntryId01")]
	public uint ArchiveEntryId01 { get; set; }

	[TableColumn("archiveEntryId02")]
	public uint ArchiveEntryId02 { get; set; }

	[TableColumn("archiveEntryId03")]
	public uint ArchiveEntryId03 { get; set; }

	[TableColumn("archiveEntryId04")]
	public uint ArchiveEntryId04 { get; set; }

	[TableColumn("archiveEntryId05")]
	public uint ArchiveEntryId05 { get; set; }

	[TableColumn("archiveEntryId06")]
	public uint ArchiveEntryId06 { get; set; }

	[TableColumn("archiveEntryId07")]
	public uint ArchiveEntryId07 { get; set; }

	[TableColumn("archiveEntryId08")]
	public uint ArchiveEntryId08 { get; set; }

	[TableColumn("archiveEntryId09")]
	public uint ArchiveEntryId09 { get; set; }

	[TableColumn("archiveEntryId10")]
	public uint ArchiveEntryId10 { get; set; }

	[TableColumn("archiveEntryId11")]
	public uint ArchiveEntryId11 { get; set; }

	[TableColumn("archiveEntryId12")]
	public uint ArchiveEntryId12 { get; set; }

	[TableColumn("archiveEntryId13")]
	public uint ArchiveEntryId13 { get; set; }

	[TableColumn("archiveEntryId14")]
	public uint ArchiveEntryId14 { get; set; }

	[TableColumn("archiveEntryId15")]
	public uint ArchiveEntryId15 { get; set; }

	[TableColumn("archiveArticleFlags")]
	public uint ArchiveArticleFlags { get; set; }

	[TableColumn("archiveCategoryId00")]
	public uint ArchiveCategoryId00 { get; set; }

	[TableColumn("archiveCategoryId01")]
	public uint ArchiveCategoryId01 { get; set; }

	[TableColumn("archiveCategoryId02")]
	public uint ArchiveCategoryId02 { get; set; }

	[TableColumn("localizedTextIdToolTip")]
	public uint LocalizedTextIdToolTip { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("characterTitleIdReward")]
	public uint CharacterTitleIdReward { get; set; }

	[TableColumn("linkName")]
	public string LinkName { get; set; } = string.Empty;
}
