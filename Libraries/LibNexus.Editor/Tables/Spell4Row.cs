using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4Row
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("spell4BaseIdBaseSpell")]
	public uint Spell4BaseIdBaseSpell { get; set; }

	[TableColumn("tierIndex")]
	public uint TierIndex { get; set; }

	[TableColumn("ravelInstanceId")]
	public uint RavelInstanceId { get; set; }

	[TableColumn("castTime")]
	public uint CastTime { get; set; }

	[TableColumn("spellDuration")]
	public uint SpellDuration { get; set; }

	[TableColumn("spellCoolDown")]
	public uint SpellCoolDown { get; set; }

	[TableColumn("targetMinRange")]
	public float TargetMinRange { get; set; }

	[TableColumn("targetMaxRange")]
	public float TargetMaxRange { get; set; }

	[TableColumn("targetVerticalRange")]
	public float TargetVerticalRange { get; set; }

	[TableColumn("casterInnateRequirement0")]
	public uint CasterInnateRequirement0 { get; set; }

	[TableColumn("casterInnateRequirement1")]
	public uint CasterInnateRequirement1 { get; set; }

	[TableColumn("casterInnateRequirementValue0")]
	public uint CasterInnateRequirementValue0 { get; set; }

	[TableColumn("casterInnateRequirementValue1")]
	public uint CasterInnateRequirementValue1 { get; set; }

	[TableColumn("casterInnateRequirementEval0")]
	public uint CasterInnateRequirementEval0 { get; set; }

	[TableColumn("casterInnateRequirementEval1")]
	public uint CasterInnateRequirementEval1 { get; set; }

	[TableColumn("targetBeginInnateRequirement")]
	public uint TargetBeginInnateRequirement { get; set; }

	[TableColumn("targetBeginInnateRequirementValue")]
	public uint TargetBeginInnateRequirementValue { get; set; }

	[TableColumn("targetBeginInnateRequirementEval")]
	public uint TargetBeginInnateRequirementEval { get; set; }

	[TableColumn("innateCostType0")]
	public uint InnateCostType0 { get; set; }

	[TableColumn("innateCostType1")]
	public uint InnateCostType1 { get; set; }

	[TableColumn("innateCost0")]
	public uint InnateCost0 { get; set; }

	[TableColumn("innateCost1")]
	public uint InnateCost1 { get; set; }

	[TableColumn("innateCostEMMId0")]
	public uint InnateCostEmmId0 { get; set; }

	[TableColumn("innateCostEMMId1")]
	public uint InnateCostEmmId1 { get; set; }

	[TableColumn("channelInitialDelay")]
	public uint ChannelInitialDelay { get; set; }

	[TableColumn("channelMaxTime")]
	public uint ChannelMaxTime { get; set; }

	[TableColumn("channelPulseTime")]
	public uint ChannelPulseTime { get; set; }

	[TableColumn("localizedTextIdActionBarTooltip")]
	public uint LocalizedTextIdActionBarTooltip { get; set; }

	[TableColumn("stackPriority")]
	public uint StackPriority { get; set; }

	[TableColumn("spell4VisualGroupId")]
	public uint Spell4VisualGroupId { get; set; }

	[TableColumn("spell4IdCastEvent00")]
	public uint Spell4IdCastEvent00 { get; set; }

	[TableColumn("spell4IdCastEvent01")]
	public uint Spell4IdCastEvent01 { get; set; }

	[TableColumn("spell4IdCastEvent02")]
	public uint Spell4IdCastEvent02 { get; set; }

	[TableColumn("spell4IdCastEvent03")]
	public uint Spell4IdCastEvent03 { get; set; }

	[TableColumn("spell4ReagentId00")]
	public uint Spell4ReagentId00 { get; set; }

	[TableColumn("spell4ReagentId01")]
	public uint Spell4ReagentId01 { get; set; }

	[TableColumn("spell4ReagentId02")]
	public uint Spell4ReagentId02 { get; set; }

	[TableColumn("spell4RunnerId00")]
	public uint Spell4RunnerId00 { get; set; }

	[TableColumn("spell4RunnerId01")]
	public uint Spell4RunnerId01 { get; set; }

	[TableColumn("runnerTargetTypeEnum00")]
	public uint RunnerTargetTypeEnum00 { get; set; }

	[TableColumn("runnerTargetTypeEnum01")]
	public uint RunnerTargetTypeEnum01 { get; set; }

	[TableColumn("prerequisiteIdRunner00")]
	public uint PrerequisiteIdRunner00 { get; set; }

	[TableColumn("prerequisiteIdRunner01")]
	public uint PrerequisiteIdRunner01 { get; set; }

	[TableColumn("abilityChargeCount")]
	public uint AbilityChargeCount { get; set; }

	[TableColumn("abilityRechargeTime")]
	public uint AbilityRechargeTime { get; set; }

	[TableColumn("abilityRechargeCount")]
	public uint AbilityRechargeCount { get; set; }

	[TableColumn("thresholdTime")]
	public uint ThresholdTime { get; set; }

	[TableColumn("abilityPointCost")]
	public uint AbilityPointCost { get; set; }

	[TableColumn("trainingCost")]
	public uint TrainingCost { get; set; }

	[TableColumn("spellChannelFlags")]
	public uint SpellChannelFlags { get; set; }

	[TableColumn("ignoreFollowTimeMs")]
	public uint IgnoreFollowTimeMs { get; set; }

	[TableColumn("spell4IdMechanicAlternateSpell")]
	public uint Spell4IdMechanicAlternateSpell { get; set; }

	[TableColumn("spell4IdPetSwitch")]
	public uint Spell4IdPetSwitch { get; set; }

	[TableColumn("spell4TagId00")]
	public uint Spell4TagId00 { get; set; }

	[TableColumn("spell4TagId01")]
	public uint Spell4TagId01 { get; set; }

	[TableColumn("spell4TagId02")]
	public uint Spell4TagId02 { get; set; }

	[TableColumn("spell4TagId03")]
	public uint Spell4TagId03 { get; set; }

	[TableColumn("spell4TagId04")]
	public uint Spell4TagId04 { get; set; }

	[TableColumn("localizedTextIdCasterIconSpellText")]
	public uint LocalizedTextIdCasterIconSpellText { get; set; }

	[TableColumn("localizedTextIdPrimaryTargetIconSpellText")]
	public uint LocalizedTextIdPrimaryTargetIconSpellText { get; set; }

	[TableColumn("localizedTextIdSecondaryTargetIconSpellText")]
	public uint LocalizedTextIdSecondaryTargetIconSpellText { get; set; }

	[TableColumn("localizedTextIdLASTier")]
	public uint LocalizedTextIdLasTier { get; set; }

	[TableColumn("localizedTextIdTooltipCastInfo")]
	public uint LocalizedTextIdTooltipCastInfo { get; set; }

	[TableColumn("localizedTextIdTooltipCostInfo")]
	public uint LocalizedTextIdTooltipCostInfo { get; set; }

	[TableColumn("tooltipCastTime")]
	public uint TooltipCastTime { get; set; }

	[TableColumn("spell4AoeTargetConstraintsId")]
	public uint Spell4AoeTargetConstraintsId { get; set; }

	[TableColumn("spell4ConditionsIdCaster")]
	public uint Spell4ConditionsIdCaster { get; set; }

	[TableColumn("spell4ConditionsIdTarget")]
	public uint Spell4ConditionsIdTarget { get; set; }

	[TableColumn("spell4CCConditionsIdCaster")]
	public uint Spell4CcConditionsIdCaster { get; set; }

	[TableColumn("spell4CCConditionsIdTarget")]
	public uint Spell4CcConditionsIdTarget { get; set; }

	[TableColumn("spellCoolDownIdGlobal")]
	public uint SpellCoolDownIdGlobal { get; set; }

	[TableColumn("spellCoolDownId00")]
	public uint SpellCoolDownId00 { get; set; }

	[TableColumn("spellCoolDownId01")]
	public uint SpellCoolDownId01 { get; set; }

	[TableColumn("spellCoolDownId02")]
	public uint SpellCoolDownId02 { get; set; }

	[TableColumn("spell4GroupListId")]
	public uint Spell4GroupListId { get; set; }

	[TableColumn("missileSpeed")]
	public uint MissileSpeed { get; set; }

	[TableColumn("minMissileSpeed")]
	public uint MinMissileSpeed { get; set; }

	[TableColumn("spell4ClientMissileId00")]
	public uint Spell4ClientMissileId00 { get; set; }

	[TableColumn("spell4ClientMissileId01")]
	public uint Spell4ClientMissileId01 { get; set; }

	[TableColumn("spell4ClientMissileId02")]
	public uint Spell4ClientMissileId02 { get; set; }

	[TableColumn("spell4ClientMissileId03")]
	public uint Spell4ClientMissileId03 { get; set; }

	[TableColumn("spell4ClientMissileId04")]
	public uint Spell4ClientMissileId04 { get; set; }

	[TableColumn("spell4ClientMissileId05")]
	public uint Spell4ClientMissileId05 { get; set; }

	[TableColumn("globalCooldownEnum")]
	public uint GlobalCooldownEnum { get; set; }

	[TableColumn("propertyFlags")]
	public uint PropertyFlags { get; set; }

	[TableColumn("uiFlags")]
	public uint UiFlags { get; set; }

	[TableColumn("spell4StackGroupId")]
	public uint Spell4StackGroupId { get; set; }

	[TableColumn("prerequisiteIdCasterCast")]
	public uint PrerequisiteIdCasterCast { get; set; }

	[TableColumn("prerequisiteIdTargetCast")]
	public uint PrerequisiteIdTargetCast { get; set; }

	[TableColumn("prerequisiteIdCasterPersistence")]
	public uint PrerequisiteIdCasterPersistence { get; set; }

	[TableColumn("prerequisiteIdTargetPersistence")]
	public uint PrerequisiteIdTargetPersistence { get; set; }

	[TableColumn("castEventConditionEnum00")]
	public uint CastEventConditionEnum00 { get; set; }

	[TableColumn("castEventConditionEnum01")]
	public uint CastEventConditionEnum01 { get; set; }

	[TableColumn("castEventConditionEnum02")]
	public uint CastEventConditionEnum02 { get; set; }

	[TableColumn("castEventConditionEnum03")]
	public uint CastEventConditionEnum03 { get; set; }

	[TableColumn("castEventTargetFlags00")]
	public uint CastEventTargetFlags00 { get; set; }

	[TableColumn("castEventTargetFlags01")]
	public uint CastEventTargetFlags01 { get; set; }

	[TableColumn("castEventTargetFlags02")]
	public uint CastEventTargetFlags02 { get; set; }

	[TableColumn("castEventTargetFlags03")]
	public uint CastEventTargetFlags03 { get; set; }

	[TableColumn("spellCastStealthChange")]
	public uint SpellCastStealthChange { get; set; }

	[TableColumn("prerequisiteIdAoeTarget")]
	public uint PrerequisiteIdAoeTarget { get; set; }

	[TableColumn("prerequisiteIdAoePreferredTarget")]
	public uint PrerequisiteIdAoePreferredTarget { get; set; }
}
