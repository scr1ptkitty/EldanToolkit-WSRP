using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundDirectionalAmbienceRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("soundEventIdOutsideStart")]
	public uint SoundEventIdOutsideStart { get; set; }

	[TableColumn("soundEventIdOutsideStop")]
	public uint SoundEventIdOutsideStop { get; set; }
}
