using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingMapInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("worldId")]
	public uint WorldId { get; set; }

	[TableColumn("privatePropertyCount")]
	public uint PrivatePropertyCount { get; set; }

	[TableColumn("publicPropertyCount")]
	public uint PublicPropertyCount { get; set; }
}
