using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class QuestDirectionEntryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[TableColumn("worldLocation2IdInactive")]
	public uint WorldLocation2IdInactive { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("questDirectionEntryFlags")]
	public uint QuestDirectionEntryFlags { get; set; }

	[TableColumn("questDirectionFactionEnum")]
	public uint QuestDirectionFactionEnum { get; set; }
}
