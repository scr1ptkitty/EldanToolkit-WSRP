using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelSequenceBySeatPostureRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("modelSequenceId")]
	public uint ModelSequenceId { get; set; }

	[TableColumn("modelSequenceIdNarrow")]
	public uint ModelSequenceIdNarrow { get; set; }

	[TableColumn("modelSequenceIdMedium")]
	public uint ModelSequenceIdMedium { get; set; }

	[TableColumn("modelSequenceIdWide")]
	public uint ModelSequenceIdWide { get; set; }

	[TableColumn("modelSequenceIdBike")]
	public uint ModelSequenceIdBike { get; set; }

	[TableColumn("modelSequenceIdHoverBoard")]
	public uint ModelSequenceIdHoverBoard { get; set; }

	[TableColumn("modelSequenceIdGlider")]
	public uint ModelSequenceIdGlider { get; set; }

	[TableColumn("modelSequenceIdTank")]
	public uint ModelSequenceIdTank { get; set; }
}
