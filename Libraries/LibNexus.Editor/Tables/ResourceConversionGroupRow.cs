using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ResourceConversionGroupRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("resourceConversionId00")]
	public uint ResourceConversionId00 { get; set; }

	[TableColumn("resourceConversionId01")]
	public uint ResourceConversionId01 { get; set; }

	[TableColumn("resourceConversionId02")]
	public uint ResourceConversionId02 { get; set; }

	[TableColumn("resourceConversionId03")]
	public uint ResourceConversionId03 { get; set; }

	[TableColumn("resourceConversionId04")]
	public uint ResourceConversionId04 { get; set; }

	[TableColumn("resourceConversionId05")]
	public uint ResourceConversionId05 { get; set; }
}
