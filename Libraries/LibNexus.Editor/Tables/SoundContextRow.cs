using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundContextRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("eventId")]
	public uint EventId { get; set; }

	[TableColumn("type")]
	public uint Type { get; set; }
}
