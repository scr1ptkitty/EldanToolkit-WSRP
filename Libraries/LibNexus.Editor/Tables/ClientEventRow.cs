using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ClientEventRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("worldId")]
	public uint WorldId { get; set; }

	[TableColumn("eventTypeEnum")]
	public uint EventTypeEnum { get; set; }

	[TableColumn("eventData")]
	public uint EventData { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("priority")]
	public uint Priority { get; set; }

	[TableColumn("delayMS")]
	public uint DelayMs { get; set; }

	[TableColumn("clientEventActionId")]
	public uint ClientEventActionId { get; set; }
}
