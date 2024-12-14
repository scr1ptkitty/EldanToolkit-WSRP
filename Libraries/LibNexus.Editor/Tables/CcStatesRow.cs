using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CcStatesRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("defaultBreakProbability")]
	public float DefaultBreakProbability { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("spellIcon")]
	public string SpellIcon { get; set; } = string.Empty;

	[TableColumn("visualEffectId00")]
	public uint VisualEffectId00 { get; set; }

	[TableColumn("visualEffectId01")]
	public uint VisualEffectId01 { get; set; }

	[TableColumn("visualEffectId02")]
	public uint VisualEffectId02 { get; set; }

	[TableColumn("ccStateDiminishingReturnsId")]
	public uint CcStateDiminishingReturnsId { get; set; }
}
