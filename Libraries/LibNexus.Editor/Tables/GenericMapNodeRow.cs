using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GenericMapNodeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("genericMapId")]
	public uint GenericMapId { get; set; }

	[TableColumn("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("spritePath")]
	public string SpritePath { get; set; } = string.Empty;

	[TableColumn("genericMapNodeTypeEnum")]
	public uint GenericMapNodeTypeEnum { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
