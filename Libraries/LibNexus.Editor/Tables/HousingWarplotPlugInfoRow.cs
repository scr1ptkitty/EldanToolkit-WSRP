using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingWarplotPlugInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("housingPlugItemId")]
	public uint HousingPlugItemId { get; set; }

	[TableColumn("maintenanceCost")]
	public uint MaintenanceCost { get; set; }

	[TableColumn("upgradeCost00")]
	public uint UpgradeCost00 { get; set; }

	[TableColumn("upgradeCost01")]
	public uint UpgradeCost01 { get; set; }

	[TableColumn("upgradeCost02")]
	public uint UpgradeCost02 { get; set; }

	[TableColumn("spell4IdAbility00")]
	public uint Spell4IdAbility00 { get; set; }

	[TableColumn("spell4IdAbility01")]
	public uint Spell4IdAbility01 { get; set; }

	[TableColumn("spell4IdAbility02")]
	public uint Spell4IdAbility02 { get; set; }

	[TableColumn("spell4IdAbility03")]
	public uint Spell4IdAbility03 { get; set; }

	[TableColumn("spell4IdAbility04")]
	public uint Spell4IdAbility04 { get; set; }

	[TableColumn("spell4IdAbility05")]
	public uint Spell4IdAbility05 { get; set; }

	[TableColumn("spell4IdAbility06")]
	public uint Spell4IdAbility06 { get; set; }

	[TableColumn("spell4IdAbility07")]
	public uint Spell4IdAbility07 { get; set; }

	[TableColumn("spell4IdAbility08")]
	public uint Spell4IdAbility08 { get; set; }

	[TableColumn("spell4IdAbility09")]
	public uint Spell4IdAbility09 { get; set; }

	[TableColumn("spell4IdAbility10")]
	public uint Spell4IdAbility10 { get; set; }

	[TableColumn("spell4IdAbility11")]
	public uint Spell4IdAbility11 { get; set; }
}
