using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventStatDisplayRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("publicEventTypeEnum")]
	public uint PublicEventTypeEnum { get; set; }

	[TableColumn("publicEventId")]
	public uint PublicEventId { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
