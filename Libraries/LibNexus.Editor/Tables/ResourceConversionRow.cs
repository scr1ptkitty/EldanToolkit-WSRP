using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ResourceConversionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("resourceConversionTypeEnum")]
	public uint ResourceConversionTypeEnum { get; set; }

	[TableColumn("sourceId")]
	public uint SourceId { get; set; }

	[TableColumn("sourceCount")]
	public uint SourceCount { get; set; }

	[TableColumn("targetId")]
	public uint TargetId { get; set; }

	[TableColumn("targetCount")]
	public uint TargetCount { get; set; }

	[TableColumn("surchargeId")]
	public uint SurchargeId { get; set; }

	[TableColumn("surchargeCount")]
	public uint SurchargeCount { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
