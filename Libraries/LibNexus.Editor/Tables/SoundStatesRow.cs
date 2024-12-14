using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundStatesRow
{
	[TableColumn("id")]
	public uint Id { get; set; }

	[TableColumn("nameHash")]
	public uint NameHash { get; set; }

	[TableColumn("soundGroupHash")]
	public uint SoundGroupHash { get; set; }
}
