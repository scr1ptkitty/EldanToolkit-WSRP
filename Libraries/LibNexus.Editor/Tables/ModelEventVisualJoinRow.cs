using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelEventVisualJoinRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("unitVisualTypeId")]
	public uint UnitVisualTypeId { get; set; }

	[TableColumn("itemVisualTypeId")]
	public uint ItemVisualTypeId { get; set; }

	[TableColumn("materialTypeId")]
	public uint MaterialTypeId { get; set; }

	[TableColumn("modelEventId")]
	public uint ModelEventId { get; set; }

	[TableColumn("visualEffectId")]
	public uint VisualEffectId { get; set; }

	[TableColumn("modelSequenceId")]
	public uint ModelSequenceId { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
