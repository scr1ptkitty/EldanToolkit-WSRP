using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ClassRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("localizedTextIdNameFemale")]
	public uint LocalizedTextIdNameFemale { get; set; }

	[TableColumn("mechanic")]
	public uint Mechanic { get; set; }

	[TableColumn("spell4IdInnateAbilityActive00")]
	public uint Spell4IdInnateAbilityActive00 { get; set; }

	[TableColumn("spell4IdInnateAbilityActive01")]
	public uint Spell4IdInnateAbilityActive01 { get; set; }

	[TableColumn("spell4IdInnateAbilityActive02")]
	public uint Spell4IdInnateAbilityActive02 { get; set; }

	[TableColumn("spell4IdInnateAbilityPassive00")]
	public uint Spell4IdInnateAbilityPassive00 { get; set; }

	[TableColumn("spell4IdInnateAbilityPassive01")]
	public uint Spell4IdInnateAbilityPassive01 { get; set; }

	[TableColumn("spell4IdInnateAbilityPassive02")]
	public uint Spell4IdInnateAbilityPassive02 { get; set; }

	[TableColumn("prerequisiteIdInnateAbility00")]
	public uint PrerequisiteIdInnateAbility00 { get; set; }

	[TableColumn("prerequisiteIdInnateAbility01")]
	public uint PrerequisiteIdInnateAbility01 { get; set; }

	[TableColumn("prerequisiteIdInnateAbility02")]
	public uint PrerequisiteIdInnateAbility02 { get; set; }

	[TableColumn("startingItemProficiencies")]
	public uint StartingItemProficiencies { get; set; }

	[TableColumn("spell4IdAttackPrimary00")]
	public uint Spell4IdAttackPrimary00 { get; set; }

	[TableColumn("spell4IdAttackPrimary01")]
	public uint Spell4IdAttackPrimary01 { get; set; }

	[TableColumn("spell4IdAttackUnarmed00")]
	public uint Spell4IdAttackUnarmed00 { get; set; }

	[TableColumn("spell4IdAttackUnarmed01")]
	public uint Spell4IdAttackUnarmed01 { get; set; }

	[TableColumn("spell4IdResAbility")]
	public uint Spell4IdResAbility { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("spell4GroupId")]
	public uint Spell4GroupId { get; set; }

	[TableColumn("classIdForClassApModifier")]
	public uint ClassIdForClassApModifier { get; set; }

	[TableColumn("vitalEnumResource00")]
	public uint VitalEnumResource00 { get; set; }

	[TableColumn("vitalEnumResource01")]
	public uint VitalEnumResource01 { get; set; }

	[TableColumn("vitalEnumResource02")]
	public uint VitalEnumResource02 { get; set; }

	[TableColumn("vitalEnumResource03")]
	public uint VitalEnumResource03 { get; set; }

	[TableColumn("vitalEnumResource04")]
	public uint VitalEnumResource04 { get; set; }

	[TableColumn("vitalEnumResource05")]
	public uint VitalEnumResource05 { get; set; }

	[TableColumn("vitalEnumResource06")]
	public uint VitalEnumResource06 { get; set; }

	[TableColumn("vitalEnumResource07")]
	public uint VitalEnumResource07 { get; set; }

	[TableColumn("localizedTextIdResourceAlert00")]
	public uint LocalizedTextIdResourceAlert00 { get; set; }

	[TableColumn("localizedTextIdResourceAlert01")]
	public uint LocalizedTextIdResourceAlert01 { get; set; }

	[TableColumn("localizedTextIdResourceAlert02")]
	public uint LocalizedTextIdResourceAlert02 { get; set; }

	[TableColumn("localizedTextIdResourceAlert03")]
	public uint LocalizedTextIdResourceAlert03 { get; set; }

	[TableColumn("localizedTextIdResourceAlert04")]
	public uint LocalizedTextIdResourceAlert04 { get; set; }

	[TableColumn("localizedTextIdResourceAlert05")]
	public uint LocalizedTextIdResourceAlert05 { get; set; }

	[TableColumn("localizedTextIdResourceAlert06")]
	public uint LocalizedTextIdResourceAlert06 { get; set; }

	[TableColumn("localizedTextIdResourceAlert07")]
	public uint LocalizedTextIdResourceAlert07 { get; set; }

	[TableColumn("attributeMilestoneGroupId00")]
	public uint AttributeMilestoneGroupId00 { get; set; }

	[TableColumn("attributeMilestoneGroupId01")]
	public uint AttributeMilestoneGroupId01 { get; set; }

	[TableColumn("attributeMilestoneGroupId02")]
	public uint AttributeMilestoneGroupId02 { get; set; }

	[TableColumn("attributeMilestoneGroupId03")]
	public uint AttributeMilestoneGroupId03 { get; set; }

	[TableColumn("attributeMilestoneGroupId04")]
	public uint AttributeMilestoneGroupId04 { get; set; }

	[TableColumn("attributeMilestoneGroupId05")]
	public uint AttributeMilestoneGroupId05 { get; set; }

	[TableColumn("classSecondaryStatBonusId00")]
	public uint ClassSecondaryStatBonusId00 { get; set; }

	[TableColumn("classSecondaryStatBonusId01")]
	public uint ClassSecondaryStatBonusId01 { get; set; }

	[TableColumn("classSecondaryStatBonusId02")]
	public uint ClassSecondaryStatBonusId02 { get; set; }

	[TableColumn("classSecondaryStatBonusId03")]
	public uint ClassSecondaryStatBonusId03 { get; set; }

	[TableColumn("classSecondaryStatBonusId04")]
	public uint ClassSecondaryStatBonusId04 { get; set; }

	[TableColumn("classSecondaryStatBonusId05")]
	public uint ClassSecondaryStatBonusId05 { get; set; }

	[TableColumn("attributeMiniMilestoneGroupId00")]
	public uint AttributeMiniMilestoneGroupId00 { get; set; }

	[TableColumn("attributeMiniMilestoneGroupId01")]
	public uint AttributeMiniMilestoneGroupId01 { get; set; }

	[TableColumn("attributeMiniMilestoneGroupId02")]
	public uint AttributeMiniMilestoneGroupId02 { get; set; }

	[TableColumn("attributeMiniMilestoneGroupId03")]
	public uint AttributeMiniMilestoneGroupId03 { get; set; }

	[TableColumn("attributeMiniMilestoneGroupId04")]
	public uint AttributeMiniMilestoneGroupId04 { get; set; }

	[TableColumn("attributeMiniMilestoneGroupId05")]
	public uint AttributeMiniMilestoneGroupId05 { get; set; }

	[TableColumn("attributeMilestoneMaxTiers00")]
	public uint AttributeMilestoneMaxTiers00 { get; set; }

	[TableColumn("attributeMilestoneMaxTiers01")]
	public uint AttributeMilestoneMaxTiers01 { get; set; }

	[TableColumn("attributeMilestoneMaxTiers02")]
	public uint AttributeMilestoneMaxTiers02 { get; set; }

	[TableColumn("attributeMilestoneMaxTiers03")]
	public uint AttributeMilestoneMaxTiers03 { get; set; }

	[TableColumn("attributeMilestoneMaxTiers04")]
	public uint AttributeMilestoneMaxTiers04 { get; set; }

	[TableColumn("attributeMilestoneMaxTiers05")]
	public uint AttributeMilestoneMaxTiers05 { get; set; }
}
