using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PeriodicQuestGroupRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("periodicQuestSetId")]
	public uint PeriodicQuestSetId { get; set; }

	[TableColumn("periodicQuestsOffered")]
	public uint PeriodicQuestsOffered { get; set; }

	[TableColumn("maxPeriodicQuestsAllowed")]
	public uint MaxPeriodicQuestsAllowed { get; set; }

	[TableColumn("weight")]
	public uint Weight { get; set; }

	[TableColumn("contractTypeEnum")]
	public uint ContractTypeEnum { get; set; }

	[TableColumn("contractQualityEnum")]
	public uint ContractQualityEnum { get; set; }
}
