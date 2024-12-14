using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MiniMapMarkerRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("luaName")]
	public string LuaName { get; set; } = string.Empty;
}
