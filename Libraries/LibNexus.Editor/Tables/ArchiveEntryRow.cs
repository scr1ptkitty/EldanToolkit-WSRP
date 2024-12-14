using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ArchiveEntryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdHeading")]
	public uint LocalizedTextIdHeading { get; set; }

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

	[TableColumn("localizedTextIdTextScientist00")]
	public uint LocalizedTextIdTextScientist00 { get; set; }

	[TableColumn("localizedTextIdTextScientist01")]
	public uint LocalizedTextIdTextScientist01 { get; set; }

	[TableColumn("localizedTextIdTextScientist02")]
	public uint LocalizedTextIdTextScientist02 { get; set; }

	[TableColumn("localizedTextIdTextScientist03")]
	public uint LocalizedTextIdTextScientist03 { get; set; }

	[TableColumn("localizedTextIdTextScientist04")]
	public uint LocalizedTextIdTextScientist04 { get; set; }

	[TableColumn("localizedTextIdTextScientist05")]
	public uint LocalizedTextIdTextScientist05 { get; set; }

	[TableColumn("creature2IdPortrait")]
	public uint Creature2IdPortrait { get; set; }

	[TableColumn("iconAssetPath")]
	public string IconAssetPath { get; set; } = string.Empty;

	[TableColumn("inlineAssetPath")]
	public string InlineAssetPath { get; set; } = string.Empty;

	[TableColumn("archiveEntryTypeEnum")]
	public uint ArchiveEntryTypeEnum { get; set; }

	[TableColumn("archiveEntryFlags")]
	public uint ArchiveEntryFlags { get; set; }

	[TableColumn("archiveEntryHeaderEnum")]
	public uint ArchiveEntryHeaderEnum { get; set; }

	[TableColumn("characterTitleIdReward")]
	public uint CharacterTitleIdReward { get; set; }
}
