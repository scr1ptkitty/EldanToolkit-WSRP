using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LocalizedTextRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("soundEventId")]
	public uint SoundEventId { get; set; }

	[TableColumn("soundEventIdFemale")]
	public uint SoundEventIdFemale { get; set; }

	[TableColumn("version")]
	public uint Version { get; set; }

	[TableColumn("unitVoiceTypeId")]
	public uint UnitVoiceTypeId { get; set; }

	[TableColumn("stringContextEnum")]
	public uint StringContextEnum { get; set; }

	[TableColumn("soundAvailabilityFlagFemale")]
	public uint SoundAvailabilityFlagFemale { get; set; }
}
