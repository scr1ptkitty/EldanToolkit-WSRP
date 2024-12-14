using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4EffectsRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("spellId")]
	public uint SpellId { get; set; }

	[TableColumn("targetFlags")]
	public uint TargetFlags { get; set; }

	[TableColumn("effectType")]
	public uint EffectType { get; set; }

	[TableColumn("damageType")]
	public uint DamageType { get; set; }

	[TableColumn("delayTime")]
	public uint DelayTime { get; set; }

	[TableColumn("tickTime")]
	public uint TickTime { get; set; }

	[TableColumn("durationTime")]
	public uint DurationTime { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("dataBits00")]
	public uint DataBits00 { get; set; }

	[TableColumn("dataBits01")]
	public uint DataBits01 { get; set; }

	[TableColumn("dataBits02")]
	public uint DataBits02 { get; set; }

	[TableColumn("dataBits03")]
	public uint DataBits03 { get; set; }

	[TableColumn("dataBits04")]
	public uint DataBits04 { get; set; }

	[TableColumn("dataBits05")]
	public uint DataBits05 { get; set; }

	[TableColumn("dataBits06")]
	public uint DataBits06 { get; set; }

	[TableColumn("dataBits07")]
	public uint DataBits07 { get; set; }

	[TableColumn("dataBits08")]
	public uint DataBits08 { get; set; }

	[TableColumn("dataBits09")]
	public uint DataBits09 { get; set; }

	[TableColumn("innateCostPerTickType0")]
	public uint InnateCostPerTickType0 { get; set; }

	[TableColumn("innateCostPerTickType1")]
	public uint InnateCostPerTickType1 { get; set; }

	[TableColumn("innateCostPerTick0")]
	public uint InnateCostPerTick0 { get; set; }

	[TableColumn("innateCostPerTick1")]
	public uint InnateCostPerTick1 { get; set; }

	[TableColumn("emmComparison")]
	public uint EmmComparison { get; set; }

	[TableColumn("emmValue")]
	public uint EmmValue { get; set; }

	[TableColumn("threatMultiplier")]
	public float ThreatMultiplier { get; set; }

	[TableColumn("spell4EffectGroupListId")]
	public uint Spell4EffectGroupListId { get; set; }

	[TableColumn("prerequisiteIdCasterApply")]
	public uint PrerequisiteIdCasterApply { get; set; }

	[TableColumn("prerequisiteIdTargetApply")]
	public uint PrerequisiteIdTargetApply { get; set; }

	[TableColumn("prerequisiteIdCasterPersistence")]
	public uint PrerequisiteIdCasterPersistence { get; set; }

	[TableColumn("prerequisiteIdTargetPersistence")]
	public uint PrerequisiteIdTargetPersistence { get; set; }

	[TableColumn("prerequisiteIdTargetSuspend")]
	public uint PrerequisiteIdTargetSuspend { get; set; }

	[TableColumn("parameterType00")]
	public uint ParameterType00 { get; set; }

	[TableColumn("parameterType01")]
	public uint ParameterType01 { get; set; }

	[TableColumn("parameterType02")]
	public uint ParameterType02 { get; set; }

	[TableColumn("parameterType03")]
	public uint ParameterType03 { get; set; }

	[TableColumn("parameterValue00")]
	public float ParameterValue00 { get; set; }

	[TableColumn("parameterValue01")]
	public float ParameterValue01 { get; set; }

	[TableColumn("parameterValue02")]
	public float ParameterValue02 { get; set; }

	[TableColumn("parameterValue03")]
	public float ParameterValue03 { get; set; }

	[TableColumn("phaseFlags")]
	public uint PhaseFlags { get; set; }

	[TableColumn("orderIndex")]
	public uint OrderIndex { get; set; }
}
