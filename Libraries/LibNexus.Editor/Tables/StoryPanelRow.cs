using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class StoryPanelRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdBody")]
	public uint LocalizedTextIdBody { get; set; }

	[TableColumn("soundEventId")]
	public uint SoundEventId { get; set; }

	[TableColumn("windowTypeId")]
	public uint WindowTypeId { get; set; }

	[TableColumn("durationMS")]
	public uint DurationMs { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("storyPanelStyleEnum")]
	public uint StoryPanelStyleEnum { get; set; }
}
