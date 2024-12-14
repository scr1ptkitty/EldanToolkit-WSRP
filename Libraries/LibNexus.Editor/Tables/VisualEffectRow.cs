using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class VisualEffectRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("visualType")]
	public uint VisualType { get; set; }

	[TableColumn("startDelay")]
	public uint StartDelay { get; set; }

	[TableColumn("duration")]
	public uint Duration { get; set; }

	[TableColumn("modelItemSlot")]
	public uint ModelItemSlot { get; set; }

	[TableColumn("modelItemCostumeSide")]
	public uint ModelItemCostumeSide { get; set; }

	[TableColumn("modelAssetPath")]
	public string ModelAssetPath { get; set; } = string.Empty;

	[TableColumn("modelAttachmentId")]
	public uint ModelAttachmentId { get; set; }

	[TableColumn("modelSequencePriority")]
	public uint ModelSequencePriority { get; set; }

	[TableColumn("modelSequenceIdTarget00")]
	public uint ModelSequenceIdTarget00 { get; set; }

	[TableColumn("modelSequenceIdTarget01")]
	public uint ModelSequenceIdTarget01 { get; set; }

	[TableColumn("modelSequenceIdTarget02")]
	public uint ModelSequenceIdTarget02 { get; set; }

	[TableColumn("modelScale")]
	public float ModelScale { get; set; }

	[TableColumn("modelRotationX")]
	public float ModelRotationX { get; set; }

	[TableColumn("modelRotationY")]
	public float ModelRotationY { get; set; }

	[TableColumn("modelRotationZ")]
	public float ModelRotationZ { get; set; }

	[TableColumn("data00")]
	public float Data00 { get; set; }

	[TableColumn("data01")]
	public float Data01 { get; set; }

	[TableColumn("data02")]
	public float Data02 { get; set; }

	[TableColumn("data03")]
	public float Data03 { get; set; }

	[TableColumn("data04")]
	public float Data04 { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("soundEventId00")]
	public uint SoundEventId00 { get; set; }

	[TableColumn("soundEventId01")]
	public uint SoundEventId01 { get; set; }

	[TableColumn("soundEventId02")]
	public uint SoundEventId02 { get; set; }

	[TableColumn("soundEventId03")]
	public uint SoundEventId03 { get; set; }

	[TableColumn("soundEventId04")]
	public uint SoundEventId04 { get; set; }

	[TableColumn("soundEventId05")]
	public uint SoundEventId05 { get; set; }

	[TableColumn("soundEventOffset00")]
	public uint SoundEventOffset00 { get; set; }

	[TableColumn("soundEventOffset01")]
	public uint SoundEventOffset01 { get; set; }

	[TableColumn("soundEventOffset02")]
	public uint SoundEventOffset02 { get; set; }

	[TableColumn("soundEventOffset03")]
	public uint SoundEventOffset03 { get; set; }

	[TableColumn("soundEventOffset04")]
	public uint SoundEventOffset04 { get; set; }

	[TableColumn("soundEventOffset05")]
	public uint SoundEventOffset05 { get; set; }

	[TableColumn("soundEventIdStop")]
	public uint SoundEventIdStop { get; set; }

	[TableColumn("soundZoneKitId")]
	public uint SoundZoneKitId { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("particleDiffuseColor")]
	public uint ParticleDiffuseColor { get; set; }
}
