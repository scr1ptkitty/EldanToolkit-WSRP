using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CombatRewardRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("combatRewardTypeEnum")]
	public uint CombatRewardTypeEnum { get; set; }

	[TableColumn("localizedTextIdCombatFloater")]
	public uint LocalizedTextIdCombatFloater { get; set; }

	[TableColumn("localizedTextIdCombatLogMessage")]
	public uint LocalizedTextIdCombatLogMessage { get; set; }

	[TableColumn("visualEffectIdVisual00")]
	public uint VisualEffectIdVisual00 { get; set; }

	[TableColumn("visualEffectIdVisual01")]
	public uint VisualEffectIdVisual01 { get; set; }
}
