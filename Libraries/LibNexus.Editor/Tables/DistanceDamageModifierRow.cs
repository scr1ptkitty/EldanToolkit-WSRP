using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class DistanceDamageModifierRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("distancePercent00")]
	public float DistancePercent00 { get; set; }

	[TableColumn("distancePercent01")]
	public float DistancePercent01 { get; set; }

	[TableColumn("distancePercent02")]
	public float DistancePercent02 { get; set; }

	[TableColumn("distancePercent03")]
	public float DistancePercent03 { get; set; }

	[TableColumn("distancePercent04")]
	public float DistancePercent04 { get; set; }

	[TableColumn("damageModifier00")]
	public float DamageModifier00 { get; set; }

	[TableColumn("damageModifier01")]
	public float DamageModifier01 { get; set; }

	[TableColumn("damageModifier02")]
	public float DamageModifier02 { get; set; }

	[TableColumn("damageModifier03")]
	public float DamageModifier03 { get; set; }

	[TableColumn("damageModifier04")]
	public float DamageModifier04 { get; set; }
}
