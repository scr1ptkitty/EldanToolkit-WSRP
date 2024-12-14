using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EntitlementRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("maxCount")]
	public uint MaxCount { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("spell4IdPersistentBuff")]
	public uint Spell4IdPersistentBuff { get; set; }

	[TableColumn("characterTitleId")]
	public uint CharacterTitleId { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("buttonIcon")]
	public string ButtonIcon { get; set; } = string.Empty;
}
