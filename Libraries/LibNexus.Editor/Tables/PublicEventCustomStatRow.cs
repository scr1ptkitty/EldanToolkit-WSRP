using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventCustomStatRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("publicEventTypeEnum")]
	public uint PublicEventTypeEnum { get; set; }

	[TableColumn("publicEventId")]
	public uint PublicEventId { get; set; }

	[TableColumn("statIndex")]
	public uint StatIndex { get; set; }

	[TableColumn("localizedTextIdStatName")]
	public uint LocalizedTextIdStatName { get; set; }

	[TableColumn("iconPath")]
	public string IconPath { get; set; } = string.Empty;
}
