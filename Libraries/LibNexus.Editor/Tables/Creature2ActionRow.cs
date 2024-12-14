using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2ActionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("creatureActionSetId")]
	public uint CreatureActionSetId { get; set; }

	[TableColumn("state")]
	public uint State { get; set; }

	[TableColumn("event")]
	public uint Event { get; set; }

	[TableColumn("orderIndex")]
	public uint OrderIndex { get; set; }

	[TableColumn("delayMS")]
	public uint DelayMs { get; set; }

	[TableColumn("action")]
	public uint Action { get; set; }

	[TableColumn("actionData00")]
	public uint ActionData00 { get; set; }

	[TableColumn("actionData01")]
	public uint ActionData01 { get; set; }

	[TableColumn("visualEffectId")]
	public uint VisualEffectId { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
