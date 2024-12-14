using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TutorialPageRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("tutorialId")]
	public uint TutorialId { get; set; }

	[TableColumn("page")]
	public uint Page { get; set; }

	[TableColumn("tutorialLayoutId")]
	public uint TutorialLayoutId { get; set; }

	[TableColumn("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[TableColumn("localizedTextIdBody00")]
	public uint LocalizedTextIdBody00 { get; set; }

	[TableColumn("localizedTextIdBody01")]
	public uint LocalizedTextIdBody01 { get; set; }

	[TableColumn("localizedTextIdBody02")]
	public uint LocalizedTextIdBody02 { get; set; }

	[TableColumn("sprite00")]
	public string Sprite00 { get; set; } = string.Empty;

	[TableColumn("sprite01")]
	public string Sprite01 { get; set; } = string.Empty;

	[TableColumn("sprite02")]
	public string Sprite02 { get; set; } = string.Empty;

	[TableColumn("soundEventId")]
	public uint SoundEventId { get; set; }
}
