using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingWarplotBossTokenRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("spell4IdSummon")]
	public uint Spell4IdSummon { get; set; }

	[TableColumn("minimumUpgradeTierEnum")]
	public uint MinimumUpgradeTierEnum { get; set; }

	[TableColumn("housingPlugItemIdLinked")]
	public uint HousingPlugItemIdLinked { get; set; }
}
