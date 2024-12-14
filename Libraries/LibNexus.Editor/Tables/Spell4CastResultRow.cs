using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4CastResultRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[TableColumn("combatMessageTypeEnum")]
	public uint CombatMessageTypeEnum { get; set; }

	[TableColumn("localizedTextIdDisplayText")]
	public uint LocalizedTextIdDisplayText { get; set; }

	[TableColumn("soundEventId")]
	public uint SoundEventId { get; set; }
}
