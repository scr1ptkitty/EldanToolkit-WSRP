using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TutorialRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("tutorialCategoryEnum")]
	public uint TutorialCategoryEnum { get; set; }

	[TableColumn("localizedTextIdContextualPopup")]
	public uint LocalizedTextIdContextualPopup { get; set; }

	[TableColumn("tutorialAnchorId")]
	public uint TutorialAnchorId { get; set; }

	[TableColumn("requiredLevel")]
	public uint RequiredLevel { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
