using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4VisualRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("targetTypeFlags")]
	public uint TargetTypeFlags { get; set; }

	[TableColumn("stageType")]
	public uint StageType { get; set; }

	[TableColumn("stageFlags")]
	public uint StageFlags { get; set; }

	[TableColumn("visualEffectId")]
	public uint VisualEffectId { get; set; }

	[TableColumn("visualEffectIdSound")]
	public uint VisualEffectIdSound { get; set; }

	[TableColumn("modelEventIdDelay")]
	public uint ModelEventIdDelay { get; set; }

	[TableColumn("soundEventType00")]
	public uint SoundEventType00 { get; set; }

	[TableColumn("soundEventType01")]
	public uint SoundEventType01 { get; set; }

	[TableColumn("soundEventType02")]
	public uint SoundEventType02 { get; set; }

	[TableColumn("soundEventType03")]
	public uint SoundEventType03 { get; set; }

	[TableColumn("soundEventType04")]
	public uint SoundEventType04 { get; set; }

	[TableColumn("soundEventType05")]
	public uint SoundEventType05 { get; set; }

	[TableColumn("soundImpactDescriptionIdTarget00")]
	public uint SoundImpactDescriptionIdTarget00 { get; set; }

	[TableColumn("soundImpactDescriptionIdTarget01")]
	public uint SoundImpactDescriptionIdTarget01 { get; set; }

	[TableColumn("soundImpactDescriptionIdTarget02")]
	public uint SoundImpactDescriptionIdTarget02 { get; set; }

	[TableColumn("soundImpactDescriptionIdTarget03")]
	public uint SoundImpactDescriptionIdTarget03 { get; set; }

	[TableColumn("soundImpactDescriptionIdTarget04")]
	public uint SoundImpactDescriptionIdTarget04 { get; set; }

	[TableColumn("soundImpactDescriptionIdTarget05")]
	public uint SoundImpactDescriptionIdTarget05 { get; set; }

	[TableColumn("soundImpactDescriptionIdOrigin00")]
	public uint SoundImpactDescriptionIdOrigin00 { get; set; }

	[TableColumn("soundImpactDescriptionIdOrigin01")]
	public uint SoundImpactDescriptionIdOrigin01 { get; set; }

	[TableColumn("soundImpactDescriptionIdOrigin02")]
	public uint SoundImpactDescriptionIdOrigin02 { get; set; }

	[TableColumn("soundImpactDescriptionIdOrigin03")]
	public uint SoundImpactDescriptionIdOrigin03 { get; set; }

	[TableColumn("soundImpactDescriptionIdOrigin04")]
	public uint SoundImpactDescriptionIdOrigin04 { get; set; }

	[TableColumn("soundImpactDescriptionIdOrigin05")]
	public uint SoundImpactDescriptionIdOrigin05 { get; set; }

	[TableColumn("modelAttachmentIdCaster")]
	public uint ModelAttachmentIdCaster { get; set; }

	[TableColumn("phaseFlags")]
	public uint PhaseFlags { get; set; }

	[TableColumn("modelOffsetX")]
	public float ModelOffsetX { get; set; }

	[TableColumn("modelOffsetY")]
	public float ModelOffsetY { get; set; }

	[TableColumn("modelOffsetZ")]
	public float ModelOffsetZ { get; set; }

	[TableColumn("modelScale")]
	public float ModelScale { get; set; }

	[TableColumn("preDelayTimeMs")]
	public uint PreDelayTimeMs { get; set; }

	[TableColumn("telegraphDamageIdAttach")]
	public uint TelegraphDamageIdAttach { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
