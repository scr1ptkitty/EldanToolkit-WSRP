using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GuildPermissionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("luaVariable")]
	public string LuaVariable { get; set; } = string.Empty;

	[TableColumn("localizedTextIdCommand")]
	public uint LocalizedTextIdCommand { get; set; }

	[TableColumn("guildTypeEnumFlags")]
	public uint GuildTypeEnumFlags { get; set; }

	[TableColumn("displayIndex")]
	public uint DisplayIndex { get; set; }
}
