using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SpellPhaseRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("phaseDelay")]
	public uint PhaseDelay { get; set; }

	[TableColumn("phaseFlags")]
	public uint PhaseFlags { get; set; }

	[TableColumn("orderIndex")]
	public uint OrderIndex { get; set; }

	[TableColumn("spell4IdOwner")]
	public uint Spell4IdOwner { get; set; }
}
