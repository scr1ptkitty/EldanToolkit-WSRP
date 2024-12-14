using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4ClientMissileRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("missileType")]
	public uint MissileType { get; set; }

	[TableColumn("castStage")]
	public uint CastStage { get; set; }

	[TableColumn("originUnitEnum")]
	public uint OriginUnitEnum { get; set; }

	[TableColumn("targetFlags")]
	public uint TargetFlags { get; set; }

	[TableColumn("modelPath")]
	public string ModelPath { get; set; } = string.Empty;

	[TableColumn("fxPath")]
	public string FxPath { get; set; } = string.Empty;

	[TableColumn("beamPath")]
	public string BeamPath { get; set; } = string.Empty;

	[TableColumn("beamSource")]
	public uint BeamSource { get; set; }

	[TableColumn("beamTarget")]
	public uint BeamTarget { get; set; }

	[TableColumn("itemSlot")]
	public uint ItemSlot { get; set; }

	[TableColumn("costumeSide")]
	public uint CostumeSide { get; set; }

	[TableColumn("modelAttachmentIdCaster")]
	public uint ModelAttachmentIdCaster { get; set; }

	[TableColumn("modelAttachmentIdTarget")]
	public uint ModelAttachmentIdTarget { get; set; }

	[TableColumn("clientDelay")]
	public uint ClientDelay { get; set; }

	[TableColumn("modelEventIdDelayedBy")]
	public uint ModelEventIdDelayedBy { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("duration")]
	public uint Duration { get; set; }

	[TableColumn("frequency")]
	public uint Frequency { get; set; }

	[TableColumn("speedMps")]
	public uint SpeedMps { get; set; }

	[TableColumn("accMpss")]
	public float AccMpss { get; set; }

	[TableColumn("revolverNestedMissileInitDelay")]
	public uint RevolverNestedMissileInitDelay { get; set; }

	[TableColumn("revolverNestedMissileSubDelay")]
	public uint RevolverNestedMissileSubDelay { get; set; }

	[TableColumn("spell4ClientMissileIdNested")]
	public uint Spell4ClientMissileIdNested { get; set; }

	[TableColumn("revolverMissileImpactAssetPath")]
	public string RevolverMissileImpactAssetPath { get; set; } = string.Empty;

	[TableColumn("missileRevolverTrackId")]
	public uint MissileRevolverTrackId { get; set; }

	[TableColumn("birthAnchorPath")]
	public string BirthAnchorPath { get; set; } = string.Empty;

	[TableColumn("deathAnchorPath")]
	public string DeathAnchorPath { get; set; } = string.Empty;

	[TableColumn("trajAnchorPath")]
	public string TrajAnchorPath { get; set; } = string.Empty;

	[TableColumn("birthDuration")]
	public float BirthDuration { get; set; }

	[TableColumn("birthAnchorAngleMin")]
	public float BirthAnchorAngleMin { get; set; }

	[TableColumn("birthAnchorAngleMax")]
	public float BirthAnchorAngleMax { get; set; }

	[TableColumn("deathAnchorAngleMin")]
	public float DeathAnchorAngleMin { get; set; }

	[TableColumn("deathAnchorAngleMax")]
	public float DeathAnchorAngleMax { get; set; }

	[TableColumn("deathAnchorSpace")]
	public uint DeathAnchorSpace { get; set; }

	[TableColumn("itemSlotIdObj")]
	public uint ItemSlotIdObj { get; set; }

	[TableColumn("objCostumeSide")]
	public uint ObjCostumeSide { get; set; }

	[TableColumn("trajPoseFullBlendDistance")]
	public float TrajPoseFullBlendDistance { get; set; }

	[TableColumn("trajAnchorPlaySpeed")]
	public float TrajAnchorPlaySpeed { get; set; }

	[TableColumn("parabolaHeightScale")]
	public float ParabolaHeightScale { get; set; }

	[TableColumn("rotateX")]
	public float RotateX { get; set; }

	[TableColumn("rotateY")]
	public float RotateY { get; set; }

	[TableColumn("rotateZ")]
	public float RotateZ { get; set; }

	[TableColumn("scale")]
	public float Scale { get; set; }

	[TableColumn("endScale")]
	public float EndScale { get; set; }

	[TableColumn("phaseFlags")]
	public uint PhaseFlags { get; set; }

	[TableColumn("telegraphDamageIdAttach")]
	public uint TelegraphDamageIdAttach { get; set; }

	[TableColumn("soundEventIdBirth")]
	public uint SoundEventIdBirth { get; set; }

	[TableColumn("soundEventIdLoopStart")]
	public uint SoundEventIdLoopStart { get; set; }

	[TableColumn("soundEventIdLoopStop")]
	public uint SoundEventIdLoopStop { get; set; }

	[TableColumn("soundEventIdDeath")]
	public uint SoundEventIdDeath { get; set; }

	[TableColumn("beamDiffuseColor")]
	public uint BeamDiffuseColor { get; set; }

	[TableColumn("missileDiffuseColor")]
	public uint MissileDiffuseColor { get; set; }
}
