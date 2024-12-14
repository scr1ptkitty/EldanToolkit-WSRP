using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelPoseRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("sequenceId")]
	public uint SequenceId { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("modelPoseIdBase")]
	public uint ModelPoseIdBase { get; set; }

	[TableColumn("modelPoseTypeEnum")]
	public uint ModelPoseTypeEnum { get; set; }
}
