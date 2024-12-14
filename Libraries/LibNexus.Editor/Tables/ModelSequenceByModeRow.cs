using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelSequenceByModeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("modelSequenceId")]
	public uint ModelSequenceId { get; set; }

	[TableColumn("modelSequenceIdSwim")]
	public uint ModelSequenceIdSwim { get; set; }

	[TableColumn("modelSequenceIdHover")]
	public uint ModelSequenceIdHover { get; set; }

	[TableColumn("modelSequenceIdFly")]
	public uint ModelSequenceIdFly { get; set; }
}
