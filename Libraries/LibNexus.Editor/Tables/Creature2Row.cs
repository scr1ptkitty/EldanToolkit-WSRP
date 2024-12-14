using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2Row
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("CreationTypeEnum")]
	public uint CreationTypeEnum { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("creature2AoiSizeEnum")]
	public uint Creature2AoiSizeEnum { get; set; }

	[TableColumn("unitRaceId")]
	public uint UnitRaceId { get; set; }

	[TableColumn("creature2DifficultyId")]
	public uint Creature2DifficultyId { get; set; }

	[TableColumn("creature2ArcheTypeId")]
	public uint Creature2ArcheTypeId { get; set; }

	[TableColumn("creature2TierId")]
	public uint Creature2TierId { get; set; }

	[TableColumn("creature2ModelInfoId")]
	public uint Creature2ModelInfoId { get; set; }

	[TableColumn("creature2DisplayGroupId")]
	public uint Creature2DisplayGroupId { get; set; }

	[TableColumn("creature2OutfitGroupId")]
	public uint Creature2OutfitGroupId { get; set; }

	[TableColumn("prerequisiteIdVisibility")]
	public uint PrerequisiteIdVisibility { get; set; }

	[TableColumn("modelScale")]
	public float ModelScale { get; set; }

	[TableColumn("spell4IdActivate00")]
	public uint Spell4IdActivate00 { get; set; }

	[TableColumn("spell4IdActivate01")]
	public uint Spell4IdActivate01 { get; set; }

	[TableColumn("spell4IdActivate02")]
	public uint Spell4IdActivate02 { get; set; }

	[TableColumn("spell4IdActivate03")]
	public uint Spell4IdActivate03 { get; set; }

	[TableColumn("prerequisiteIdActivateSpell00")]
	public uint PrerequisiteIdActivateSpell00 { get; set; }

	[TableColumn("prerequisiteIdActivateSpell01")]
	public uint PrerequisiteIdActivateSpell01 { get; set; }

	[TableColumn("prerequisiteIdActivateSpell02")]
	public uint PrerequisiteIdActivateSpell02 { get; set; }

	[TableColumn("prerequisiteIdActivateSpell03")]
	public uint PrerequisiteIdActivateSpell03 { get; set; }

	[TableColumn("activateSpellCastTime")]
	public uint ActivateSpellCastTime { get; set; }

	[TableColumn("activateSpellMinRange")]
	public float ActivateSpellMinRange { get; set; }

	[TableColumn("activateSpellMaxRange")]
	public float ActivateSpellMaxRange { get; set; }

	[TableColumn("localizedTextIdActivateSpellText")]
	public uint LocalizedTextIdActivateSpellText { get; set; }

	[TableColumn("spell4VisualGroupIdActivateSpell")]
	public uint Spell4VisualGroupIdActivateSpell { get; set; }

	[TableColumn("trainerClassIdMask")]
	public uint TrainerClassIdMask { get; set; }

	[TableColumn("tradeSkillIdTrainer")]
	public uint TradeSkillIdTrainer { get; set; }

	[TableColumn("tradeSkillIdStation")]
	public uint TradeSkillIdStation { get; set; }

	[TableColumn("questIdGiven00")]
	public uint QuestIdGiven00 { get; set; }

	[TableColumn("questIdGiven01")]
	public uint QuestIdGiven01 { get; set; }

	[TableColumn("questIdGiven02")]
	public uint QuestIdGiven02 { get; set; }

	[TableColumn("questIdGiven03")]
	public uint QuestIdGiven03 { get; set; }

	[TableColumn("questIdGiven04")]
	public uint QuestIdGiven04 { get; set; }

	[TableColumn("questIdGiven05")]
	public uint QuestIdGiven05 { get; set; }

	[TableColumn("questIdGiven06")]
	public uint QuestIdGiven06 { get; set; }

	[TableColumn("questIdGiven07")]
	public uint QuestIdGiven07 { get; set; }

	[TableColumn("questIdGiven08")]
	public uint QuestIdGiven08 { get; set; }

	[TableColumn("questIdGiven09")]
	public uint QuestIdGiven09 { get; set; }

	[TableColumn("questIdGiven10")]
	public uint QuestIdGiven10 { get; set; }

	[TableColumn("questIdGiven11")]
	public uint QuestIdGiven11 { get; set; }

	[TableColumn("questIdGiven12")]
	public uint QuestIdGiven12 { get; set; }

	[TableColumn("questIdGiven13")]
	public uint QuestIdGiven13 { get; set; }

	[TableColumn("questIdGiven14")]
	public uint QuestIdGiven14 { get; set; }

	[TableColumn("questIdGiven15")]
	public uint QuestIdGiven15 { get; set; }

	[TableColumn("questIdGiven16")]
	public uint QuestIdGiven16 { get; set; }

	[TableColumn("questIdGiven17")]
	public uint QuestIdGiven17 { get; set; }

	[TableColumn("questIdGiven18")]
	public uint QuestIdGiven18 { get; set; }

	[TableColumn("questIdGiven19")]
	public uint QuestIdGiven19 { get; set; }

	[TableColumn("questIdGiven20")]
	public uint QuestIdGiven20 { get; set; }

	[TableColumn("questIdGiven21")]
	public uint QuestIdGiven21 { get; set; }

	[TableColumn("questIdGiven22")]
	public uint QuestIdGiven22 { get; set; }

	[TableColumn("questIdGiven23")]
	public uint QuestIdGiven23 { get; set; }

	[TableColumn("questIdGiven24")]
	public uint QuestIdGiven24 { get; set; }

	[TableColumn("questIdReceive00")]
	public uint QuestIdReceive00 { get; set; }

	[TableColumn("questIdReceive01")]
	public uint QuestIdReceive01 { get; set; }

	[TableColumn("questIdReceive02")]
	public uint QuestIdReceive02 { get; set; }

	[TableColumn("questIdReceive03")]
	public uint QuestIdReceive03 { get; set; }

	[TableColumn("questIdReceive04")]
	public uint QuestIdReceive04 { get; set; }

	[TableColumn("questIdReceive05")]
	public uint QuestIdReceive05 { get; set; }

	[TableColumn("questIdReceive06")]
	public uint QuestIdReceive06 { get; set; }

	[TableColumn("questIdReceive07")]
	public uint QuestIdReceive07 { get; set; }

	[TableColumn("questIdReceive08")]
	public uint QuestIdReceive08 { get; set; }

	[TableColumn("questIdReceive09")]
	public uint QuestIdReceive09 { get; set; }

	[TableColumn("questIdReceive10")]
	public uint QuestIdReceive10 { get; set; }

	[TableColumn("questIdReceive11")]
	public uint QuestIdReceive11 { get; set; }

	[TableColumn("questIdReceive12")]
	public uint QuestIdReceive12 { get; set; }

	[TableColumn("questIdReceive13")]
	public uint QuestIdReceive13 { get; set; }

	[TableColumn("questIdReceive14")]
	public uint QuestIdReceive14 { get; set; }

	[TableColumn("questIdReceive15")]
	public uint QuestIdReceive15 { get; set; }

	[TableColumn("questIdReceive16")]
	public uint QuestIdReceive16 { get; set; }

	[TableColumn("questIdReceive17")]
	public uint QuestIdReceive17 { get; set; }

	[TableColumn("questIdReceive18")]
	public uint QuestIdReceive18 { get; set; }

	[TableColumn("questIdReceive19")]
	public uint QuestIdReceive19 { get; set; }

	[TableColumn("questIdReceive20")]
	public uint QuestIdReceive20 { get; set; }

	[TableColumn("questIdReceive21")]
	public uint QuestIdReceive21 { get; set; }

	[TableColumn("questIdReceive22")]
	public uint QuestIdReceive22 { get; set; }

	[TableColumn("questIdReceive23")]
	public uint QuestIdReceive23 { get; set; }

	[TableColumn("questIdReceive24")]
	public uint QuestIdReceive24 { get; set; }

	[TableColumn("questAnimStateId")]
	public uint QuestAnimStateId { get; set; }

	[TableColumn("prerequisiteIdAnimState")]
	public uint PrerequisiteIdAnimState { get; set; }

	[TableColumn("questAnimObjectiveIndex")]
	public uint QuestAnimObjectiveIndex { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("uiFlags")]
	public uint UiFlags { get; set; }

	[TableColumn("activationFlags")]
	public uint ActivationFlags { get; set; }

	[TableColumn("aimYawConstraint")]
	public float AimYawConstraint { get; set; }

	[TableColumn("aimPitchUpConstraint")]
	public float AimPitchUpConstraint { get; set; }

	[TableColumn("aimPitchDownConstraint")]
	public float AimPitchDownConstraint { get; set; }

	[TableColumn("item2IdMTXKey00")]
	public uint Item2IdMtxKey00 { get; set; }

	[TableColumn("item2IdMTXKey01")]
	public uint Item2IdMtxKey01 { get; set; }

	[TableColumn("creature2FamilyId")]
	public uint Creature2FamilyId { get; set; }

	[TableColumn("creature2TractId")]
	public uint Creature2TractId { get; set; }

	[TableColumn("bindPointId")]
	public uint BindPointId { get; set; }

	[TableColumn("resourceConversionGroupId")]
	public uint ResourceConversionGroupId { get; set; }

	[TableColumn("taxiNodeId")]
	public uint TaxiNodeId { get; set; }

	[TableColumn("pathScientistExperimentationId")]
	public uint PathScientistExperimentationId { get; set; }

	[TableColumn("datacubeId")]
	public uint DatacubeId { get; set; }

	[TableColumn("datacubeVolumeId")]
	public uint DatacubeVolumeId { get; set; }

	[TableColumn("factionId")]
	public uint FactionId { get; set; }

	[TableColumn("minLevel")]
	public uint MinLevel { get; set; }

	[TableColumn("maxLevel")]
	public uint MaxLevel { get; set; }

	[TableColumn("rescanCooldownTypeEnum")]
	public uint RescanCooldownTypeEnum { get; set; }

	[TableColumn("rescanCooldown")]
	public uint RescanCooldown { get; set; }

	[TableColumn("creature2AffiliationId")]
	public uint Creature2AffiliationId { get; set; }

	[TableColumn("itemIdDisplayItemRight")]
	public uint ItemIdDisplayItemRight { get; set; }

	[TableColumn("soundEventIdAggro")]
	public uint SoundEventIdAggro { get; set; }

	[TableColumn("soundEventIdAware")]
	public uint SoundEventIdAware { get; set; }

	[TableColumn("soundImpactDescriptionIdOrigin")]
	public uint SoundImpactDescriptionIdOrigin { get; set; }

	[TableColumn("soundImpactDescriptionIdTarget")]
	public uint SoundImpactDescriptionIdTarget { get; set; }

	[TableColumn("soundSwitchIdModel")]
	public uint SoundSwitchIdModel { get; set; }

	[TableColumn("soundCombatLoopId")]
	public uint SoundCombatLoopId { get; set; }

	[TableColumn("randomTextLineIdGoodbye00")]
	public uint RandomTextLineIdGoodbye00 { get; set; }

	[TableColumn("randomTextLineIdGoodbye01")]
	public uint RandomTextLineIdGoodbye01 { get; set; }

	[TableColumn("randomTextLineIdGoodbye02")]
	public uint RandomTextLineIdGoodbye02 { get; set; }

	[TableColumn("randomTextLineIdGoodbye03")]
	public uint RandomTextLineIdGoodbye03 { get; set; }

	[TableColumn("randomTextLineIdGoodbye04")]
	public uint RandomTextLineIdGoodbye04 { get; set; }

	[TableColumn("randomTextLineIdGoodbye05")]
	public uint RandomTextLineIdGoodbye05 { get; set; }

	[TableColumn("randomTextLineIdGoodbye06")]
	public uint RandomTextLineIdGoodbye06 { get; set; }

	[TableColumn("randomTextLineIdGoodbye07")]
	public uint RandomTextLineIdGoodbye07 { get; set; }

	[TableColumn("randomTextLineIdGoodbye08")]
	public uint RandomTextLineIdGoodbye08 { get; set; }

	[TableColumn("randomTextLineIdGoodbye09")]
	public uint RandomTextLineIdGoodbye09 { get; set; }

	[TableColumn("randomTextLineIdHello00")]
	public uint RandomTextLineIdHello00 { get; set; }

	[TableColumn("randomTextLineIdHello01")]
	public uint RandomTextLineIdHello01 { get; set; }

	[TableColumn("randomTextLineIdHello02")]
	public uint RandomTextLineIdHello02 { get; set; }

	[TableColumn("randomTextLineIdHello03")]
	public uint RandomTextLineIdHello03 { get; set; }

	[TableColumn("randomTextLineIdHello04")]
	public uint RandomTextLineIdHello04 { get; set; }

	[TableColumn("randomTextLineIdHello05")]
	public uint RandomTextLineIdHello05 { get; set; }

	[TableColumn("randomTextLineIdHello06")]
	public uint RandomTextLineIdHello06 { get; set; }

	[TableColumn("randomTextLineIdHello07")]
	public uint RandomTextLineIdHello07 { get; set; }

	[TableColumn("randomTextLineIdHello08")]
	public uint RandomTextLineIdHello08 { get; set; }

	[TableColumn("randomTextLineIdHello09")]
	public uint RandomTextLineIdHello09 { get; set; }

	[TableColumn("randomTextLineIdIntro")]
	public uint RandomTextLineIdIntro { get; set; }

	[TableColumn("localizedTextIdDefaultGreeting")]
	public uint LocalizedTextIdDefaultGreeting { get; set; }

	[TableColumn("randomTextLineIdReturn00")]
	public uint RandomTextLineIdReturn00 { get; set; }

	[TableColumn("randomTextLineIdReturn01")]
	public uint RandomTextLineIdReturn01 { get; set; }

	[TableColumn("randomTextLineIdReturn02")]
	public uint RandomTextLineIdReturn02 { get; set; }

	[TableColumn("randomTextLineIdReturn03")]
	public uint RandomTextLineIdReturn03 { get; set; }

	[TableColumn("randomTextLineIdReturn04")]
	public uint RandomTextLineIdReturn04 { get; set; }

	[TableColumn("randomTextLineIdReturn05")]
	public uint RandomTextLineIdReturn05 { get; set; }

	[TableColumn("randomTextLineIdReturn06")]
	public uint RandomTextLineIdReturn06 { get; set; }

	[TableColumn("randomTextLineIdReturn07")]
	public uint RandomTextLineIdReturn07 { get; set; }

	[TableColumn("randomTextLineIdReturn08")]
	public uint RandomTextLineIdReturn08 { get; set; }

	[TableColumn("randomTextLineIdReturn09")]
	public uint RandomTextLineIdReturn09 { get; set; }

	[TableColumn("localizedTextIdReturnGreeting")]
	public uint LocalizedTextIdReturnGreeting { get; set; }

	[TableColumn("randomTextLineIdCompleted")]
	public uint RandomTextLineIdCompleted { get; set; }

	[TableColumn("localizedTextIdCompletedGreeting")]
	public uint LocalizedTextIdCompletedGreeting { get; set; }

	[TableColumn("unitVoiceTypeId")]
	public uint UnitVoiceTypeId { get; set; }

	[TableColumn("gossipSetId")]
	public uint GossipSetId { get; set; }

	[TableColumn("unitVisualTypeId")]
	public uint UnitVisualTypeId { get; set; }

	[TableColumn("spell4VisualGroupIdAttached")]
	public uint Spell4VisualGroupIdAttached { get; set; }

	[TableColumn("genericStringGroupsIdInteractContext")]
	public uint GenericStringGroupsIdInteractContext { get; set; }

	[TableColumn("creature2ActionSetId")]
	public uint Creature2ActionSetId { get; set; }

	[TableColumn("creature2ActionTextId")]
	public uint Creature2ActionTextId { get; set; }

	[TableColumn("pathMissionIdSoldier")]
	public uint PathMissionIdSoldier { get; set; }

	[TableColumn("instancePortalId")]
	public uint InstancePortalId { get; set; }

	[TableColumn("modelSequenceIdAnimationPriority00")]
	public uint ModelSequenceIdAnimationPriority00 { get; set; }

	[TableColumn("modelSequenceIdAnimationPriority01")]
	public uint ModelSequenceIdAnimationPriority01 { get; set; }

	[TableColumn("modelSequenceIdAnimationPriority02")]
	public uint ModelSequenceIdAnimationPriority02 { get; set; }

	[TableColumn("modelSequenceIdAnimationPriority03")]
	public uint ModelSequenceIdAnimationPriority03 { get; set; }

	[TableColumn("modelSequenceIdAnimationPriority04")]
	public uint ModelSequenceIdAnimationPriority04 { get; set; }

	[TableColumn("prerequisiteIdPriority00")]
	public uint PrerequisiteIdPriority00 { get; set; }

	[TableColumn("prerequisiteIdPriority01")]
	public uint PrerequisiteIdPriority01 { get; set; }

	[TableColumn("prerequisiteIdPriority02")]
	public uint PrerequisiteIdPriority02 { get; set; }

	[TableColumn("prerequisiteIdPriority03")]
	public uint PrerequisiteIdPriority03 { get; set; }

	[TableColumn("prerequisiteIdPriority04")]
	public uint PrerequisiteIdPriority04 { get; set; }

	[TableColumn("donutDrawDistance")]
	public float DonutDrawDistance { get; set; }

	[TableColumn("archiveArticleIdInteractUnlock")]
	public uint ArchiveArticleIdInteractUnlock { get; set; }

	[TableColumn("tradeskillHarvestingInfoId")]
	public uint TradeskillHarvestingInfoId { get; set; }

	[TableColumn("ccStateImmunitiesFlags")]
	public uint CcStateImmunitiesFlags { get; set; }

	[TableColumn("creature2ResistId")]
	public uint Creature2ResistId { get; set; }

	[TableColumn("unitVehicleId")]
	public uint UnitVehicleId { get; set; }

	[TableColumn("creature2DisplayInfoIdPortraitOverride")]
	public uint Creature2DisplayInfoIdPortraitOverride { get; set; }
}
