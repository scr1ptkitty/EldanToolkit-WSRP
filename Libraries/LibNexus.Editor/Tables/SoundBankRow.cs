using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundBankRow
{
	[TableColumn("id")]
	public uint Id { get; set; }

	[TableColumn("name")]
	public string Name { get; set; } = string.Empty;
}
