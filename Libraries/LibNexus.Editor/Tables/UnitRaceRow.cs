using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class UnitRaceRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("soundImpactDescriptionIdOrigin")]
	public uint SoundImpactDescriptionIdOrigin { get; set; }

	[TableColumn("soundImpactDescriptionIdTarget")]
	public uint SoundImpactDescriptionIdTarget { get; set; }

	[TableColumn("unitVisualTypeId")]
	public uint UnitVisualTypeId { get; set; }

	[TableColumn("soundEventIdAggro")]
	public uint SoundEventIdAggro { get; set; }

	[TableColumn("soundEventIdAware")]
	public uint SoundEventIdAware { get; set; }

	[TableColumn("soundSwitchIdModel")]
	public uint SoundSwitchIdModel { get; set; }

	[TableColumn("soundCombatLoopId")]
	public uint SoundCombatLoopId { get; set; }
}
