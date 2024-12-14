using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HazardRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[TableColumn("meterChangeRate")]
	public float MeterChangeRate { get; set; }

	[TableColumn("meterMaxValue")]
	public uint MeterMaxValue { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("hazardTypeEnum")]
	public uint HazardTypeEnum { get; set; }

	[TableColumn("spell4IdDamage")]
	public uint Spell4IdDamage { get; set; }

	[TableColumn("minDistanceToUnit")]
	public float MinDistanceToUnit { get; set; }

	[TableColumn("meterThreshold00")]
	public float MeterThreshold00 { get; set; }

	[TableColumn("meterThreshold01")]
	public float MeterThreshold01 { get; set; }

	[TableColumn("meterThreshold02")]
	public float MeterThreshold02 { get; set; }

	[TableColumn("spell4IdThresholdProc00")]
	public uint Spell4IdThresholdProc00 { get; set; }

	[TableColumn("spell4IdThresholdProc01")]
	public uint Spell4IdThresholdProc01 { get; set; }

	[TableColumn("spell4IdThresholdProc02")]
	public uint Spell4IdThresholdProc02 { get; set; }
}
