using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4BaseRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("spell4HitResultId")]
	public uint Spell4HitResultId { get; set; }

	[TableColumn("spell4TargetMechanicId")]
	public uint Spell4TargetMechanicId { get; set; }

	[TableColumn("spell4TargetAngleId")]
	public uint Spell4TargetAngleId { get; set; }

	[TableColumn("spell4PrerequisiteId")]
	public uint Spell4PrerequisiteId { get; set; }

	[TableColumn("spell4ValidTargetId")]
	public uint Spell4ValidTargetId { get; set; }

	[TableColumn("targetGroupIdCastGroup")]
	public uint TargetGroupIdCastGroup { get; set; }

	[TableColumn("creature2IdPositionalAoe")]
	public uint Creature2IdPositionalAoe { get; set; }

	[TableColumn("parameterAEAngle")]
	public float ParameterAeAngle { get; set; }

	[TableColumn("parameterAEMaxAngle")]
	public float ParameterAeMaxAngle { get; set; }

	[TableColumn("parameterAEDistance")]
	public float ParameterAeDistance { get; set; }

	[TableColumn("parameterAEMaxDistance")]
	public float ParameterAeMaxDistance { get; set; }

	[TableColumn("targetGroupIdAoeGroup")]
	public uint TargetGroupIdAoeGroup { get; set; }

	[TableColumn("spell4BaseIdPrerequisiteSpell")]
	public uint Spell4BaseIdPrerequisiteSpell { get; set; }

	[TableColumn("worldZoneIdZoneRequired")]
	public uint WorldZoneIdZoneRequired { get; set; }

	[TableColumn("spell4SpellTypesIdSpellType")]
	public uint Spell4SpellTypesIdSpellType { get; set; }

	[TableColumn("icon")]
	public string Icon { get; set; } = string.Empty;

	[TableColumn("castMethod")]
	public uint CastMethod { get; set; }

	[TableColumn("school")]
	public uint School { get; set; }

	[TableColumn("spellClass")]
	public uint SpellClass { get; set; }

	[TableColumn("weaponSlot")]
	public uint WeaponSlot { get; set; }

	[TableColumn("castBarType")]
	public uint CastBarType { get; set; }

	[TableColumn("mechanicAggressionMagnitude")]
	public float MechanicAggressionMagnitude { get; set; }

	[TableColumn("mechanicDominationMagnitude")]
	public float MechanicDominationMagnitude { get; set; }

	[TableColumn("modelSequencePriorityCaster")]
	public uint ModelSequencePriorityCaster { get; set; }

	[TableColumn("modelSequencePriorityTarget")]
	public uint ModelSequencePriorityTarget { get; set; }

	[TableColumn("classIdPlayer")]
	public uint ClassIdPlayer { get; set; }

	[TableColumn("clientSideInteractionId")]
	public uint ClientSideInteractionId { get; set; }

	[TableColumn("targetingFlags")]
	public uint TargetingFlags { get; set; }

	[TableColumn("telegraphFlagsEnum")]
	public uint TelegraphFlagsEnum { get; set; }

	[TableColumn("localizedTextIdLASTierPoint")]
	public uint LocalizedTextIdLasTierPoint { get; set; }

	[TableColumn("lasTierPointTooltipData00")]
	public float LasTierPointTooltipData00 { get; set; }

	[TableColumn("lasTierPointTooltipData01")]
	public float LasTierPointTooltipData01 { get; set; }

	[TableColumn("lasTierPointTooltipData02")]
	public float LasTierPointTooltipData02 { get; set; }

	[TableColumn("lasTierPointTooltipData03")]
	public float LasTierPointTooltipData03 { get; set; }

	[TableColumn("lasTierPointTooltipData04")]
	public float LasTierPointTooltipData04 { get; set; }

	[TableColumn("lasTierPointTooltipData05")]
	public float LasTierPointTooltipData05 { get; set; }

	[TableColumn("lasTierPointTooltipData06")]
	public float LasTierPointTooltipData06 { get; set; }

	[TableColumn("lasTierPointTooltipData07")]
	public float LasTierPointTooltipData07 { get; set; }

	[TableColumn("lasTierPointTooltipData08")]
	public float LasTierPointTooltipData08 { get; set; }

	[TableColumn("lasTierPointTooltipData09")]
	public float LasTierPointTooltipData09 { get; set; }
}
