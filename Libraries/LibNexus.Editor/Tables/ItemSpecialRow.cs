using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemSpecialRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("prerequisiteIdGeneric00")]
	public uint PrerequisiteIdGeneric00 { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("spell4IdOnEquip")]
	public uint Spell4IdOnEquip { get; set; }

	[TableColumn("spell4IdOnActivate")]
	public uint Spell4IdOnActivate { get; set; }
}
