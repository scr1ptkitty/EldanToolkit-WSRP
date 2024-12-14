using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4TagRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }
}
