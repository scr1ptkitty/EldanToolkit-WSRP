using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4ThresholdsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("spell4IdParent")]
	public uint Spell4IdParent { get; set; }

	[TableColumn("spell4IdToCast")]
	public uint Spell4IdToCast { get; set; }

	[TableColumn("orderIndex")]
	public uint OrderIndex { get; set; }

	[TableColumn("thresholdDuration")]
	public uint ThresholdDuration { get; set; }

	[TableColumn("vitalEnumCostType00")]
	public uint VitalEnumCostType00 { get; set; }

	[TableColumn("vitalEnumCostType01")]
	public uint VitalEnumCostType01 { get; set; }

	[TableColumn("vitalCostValue00")]
	public uint VitalCostValue00 { get; set; }

	[TableColumn("vitalCostValue01")]
	public uint VitalCostValue01 { get; set; }

	[TableColumn("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[TableColumn("iconReplacement")]
	public string IconReplacement { get; set; } = string.Empty;

	[TableColumn("visualEffectId")]
	public uint VisualEffectId { get; set; }
}
