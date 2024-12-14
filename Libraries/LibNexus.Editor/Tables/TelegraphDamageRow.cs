using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TelegraphDamageRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("telegraphSubtypeEnum")]
	public uint TelegraphSubtypeEnum { get; set; }

	[TableColumn("damageShapeEnum")]
	public uint DamageShapeEnum { get; set; }

	[TableColumn("param00")]
	public float Param00 { get; set; }

	[TableColumn("param01")]
	public float Param01 { get; set; }

	[TableColumn("param02")]
	public float Param02 { get; set; }

	[TableColumn("param03")]
	public float Param03 { get; set; }

	[TableColumn("param04")]
	public float Param04 { get; set; }

	[TableColumn("param05")]
	public float Param05 { get; set; }

	[TableColumn("telegraphTimeStartMs")]
	public uint TelegraphTimeStartMs { get; set; }

	[TableColumn("telegraphTimeEndMs")]
	public uint TelegraphTimeEndMs { get; set; }

	[TableColumn("telegraphTimeRampInMs")]
	public uint TelegraphTimeRampInMs { get; set; }

	[TableColumn("telegraphTimeRampOutMs")]
	public uint TelegraphTimeRampOutMs { get; set; }

	[TableColumn("xPositionOffset")]
	public float XPositionOffset { get; set; }

	[TableColumn("yPositionOffset")]
	public float YPositionOffset { get; set; }

	[TableColumn("zPositionOffset")]
	public float ZPositionOffset { get; set; }

	[TableColumn("rotationDegrees")]
	public float RotationDegrees { get; set; }

	[TableColumn("telegraphDamageFlags")]
	public uint TelegraphDamageFlags { get; set; }

	[TableColumn("targetTypeFlags")]
	public uint TargetTypeFlags { get; set; }

	[TableColumn("phaseFlags")]
	public uint PhaseFlags { get; set; }

	[TableColumn("prerequisiteIdCaster")]
	public uint PrerequisiteIdCaster { get; set; }

	[TableColumn("spellThresholdRestrictionFlags")]
	public uint SpellThresholdRestrictionFlags { get; set; }

	[TableColumn("displayFlags")]
	public uint DisplayFlags { get; set; }

	[TableColumn("opacityModifier")]
	public uint OpacityModifier { get; set; }

	[TableColumn("displayGroup")]
	public uint DisplayGroup { get; set; }
}
