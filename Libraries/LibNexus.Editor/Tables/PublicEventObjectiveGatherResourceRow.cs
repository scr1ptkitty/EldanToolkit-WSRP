using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventObjectiveGatherResourceRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("publicEventObjectiveGatherResourceEnumFlag")]
	public uint PublicEventObjectiveGatherResourceEnumFlag { get; set; }

	[TableColumn("creature2IdContainer")]
	public uint Creature2IdContainer { get; set; }

	[TableColumn("creature2IdResource")]
	public uint Creature2IdResource { get; set; }

	[TableColumn("spell4IdResource")]
	public uint Spell4IdResource { get; set; }

	[TableColumn("creature2IdStolenResource")]
	public uint Creature2IdStolenResource { get; set; }

	[TableColumn("spell4IdStolenResource")]
	public uint Spell4IdStolenResource { get; set; }

	[TableColumn("publicEventObjectiveGatherResourceIdOpposing")]
	public uint PublicEventObjectiveGatherResourceIdOpposing { get; set; }
}
