using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundEnvironmentRow
{
	[TableColumn("id")]
	public uint Id { get; set; }

	[TableColumn("hash")]
	public uint Hash { get; set; }
}
