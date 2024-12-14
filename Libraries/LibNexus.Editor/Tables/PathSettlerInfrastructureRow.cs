using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSettlerInfrastructureRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("pathSettlerHubId00")]
	public uint PathSettlerHubId00 { get; set; }

	[TableColumn("pathSettlerHubId01")]
	public uint PathSettlerHubId01 { get; set; }

	[TableColumn("localizedTextIdObjective")]
	public uint LocalizedTextIdObjective { get; set; }

	[TableColumn("missionCount")]
	public uint MissionCount { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("count")]
	public uint Count { get; set; }

	[TableColumn("maxTime")]
	public uint MaxTime { get; set; }

	[TableColumn("creature2IdDepot")]
	public uint Creature2IdDepot { get; set; }

	[TableColumn("creature2IdResource00")]
	public uint Creature2IdResource00 { get; set; }

	[TableColumn("creature2IdResource01")]
	public uint Creature2IdResource01 { get; set; }

	[TableColumn("creature2IdResource02")]
	public uint Creature2IdResource02 { get; set; }

	[TableColumn("spell4IdResource00")]
	public uint Spell4IdResource00 { get; set; }

	[TableColumn("spell4IdResource01")]
	public uint Spell4IdResource01 { get; set; }

	[TableColumn("spell4IdResource02")]
	public uint Spell4IdResource02 { get; set; }

	[TableColumn("maxStackCountResource00")]
	public uint MaxStackCountResource00 { get; set; }

	[TableColumn("maxStackCountResource01")]
	public uint MaxStackCountResource01 { get; set; }

	[TableColumn("maxStackCountResource02")]
	public uint MaxStackCountResource02 { get; set; }
}
