using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingDecorTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("luaString")]
	public string LuaString { get; set; } = string.Empty;
}
