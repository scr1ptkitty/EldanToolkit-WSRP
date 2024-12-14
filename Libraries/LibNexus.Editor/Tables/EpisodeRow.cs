using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EpisodeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdBriefing")]
	public uint LocalizedTextIdBriefing { get; set; }

	[TableColumn("localizedTextIdEndSummary")]
	public uint LocalizedTextIdEndSummary { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("percentToDisplay")]
	public uint PercentToDisplay { get; set; }

	[TableColumn("questHubIdExile")]
	public uint QuestHubIdExile { get; set; }

	[TableColumn("questHubIdDominion")]
	public uint QuestHubIdDominion { get; set; }
}
