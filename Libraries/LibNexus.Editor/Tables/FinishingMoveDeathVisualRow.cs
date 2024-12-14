using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class FinishingMoveDeathVisualRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("priority")]
	public uint Priority { get; set; }

	[TableColumn("damageTypeFlags")]
	public uint DamageTypeFlags { get; set; }

	[TableColumn("creature2MinSize")]
	public uint Creature2MinSize { get; set; }

	[TableColumn("creature2MaxSize")]
	public uint Creature2MaxSize { get; set; }

	[TableColumn("creatureMaterialEnum")]
	public uint CreatureMaterialEnum { get; set; }

	[TableColumn("movementStateFlags")]
	public uint MovementStateFlags { get; set; }

	[TableColumn("deathModelAsset")]
	public string DeathModelAsset { get; set; } = string.Empty;

	[TableColumn("modelSequenceIdDeath")]
	public uint ModelSequenceIdDeath { get; set; }

	[TableColumn("visualEffectIdDeath00")]
	public uint VisualEffectIdDeath00 { get; set; }

	[TableColumn("visualEffectIdDeath01")]
	public uint VisualEffectIdDeath01 { get; set; }

	[TableColumn("visualEffectIdDeath02")]
	public uint VisualEffectIdDeath02 { get; set; }
}
