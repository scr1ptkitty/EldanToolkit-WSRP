using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillProficiencyRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("proficiencyFlagEnum")]
	public uint ProficiencyFlagEnum { get; set; }
}
