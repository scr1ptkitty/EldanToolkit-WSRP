using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ZoneCompletionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("mapZoneId")]
	public uint MapZoneId { get; set; }

	[TableColumn("zoneCompletionFactionEnum")]
	public uint ZoneCompletionFactionEnum { get; set; }

	[TableColumn("episodeQuestCount")]
	public uint EpisodeQuestCount { get; set; }

	[TableColumn("taskQuestCount")]
	public uint TaskQuestCount { get; set; }

	[TableColumn("challengeCount")]
	public uint ChallengeCount { get; set; }

	[TableColumn("datacubeCount")]
	public uint DatacubeCount { get; set; }

	[TableColumn("taleCount")]
	public uint TaleCount { get; set; }

	[TableColumn("journalCount")]
	public uint JournalCount { get; set; }

	[TableColumn("characterTitleIdReward")]
	public uint CharacterTitleIdReward { get; set; }
}
