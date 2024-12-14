using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CcStateAdditionalDataRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("ccStatesId")]
	public uint CcStatesId { get; set; }

	[TableColumn("dataInt00")]
	public uint DataInt00 { get; set; }

	[TableColumn("dataInt01")]
	public uint DataInt01 { get; set; }

	[TableColumn("dataInt02")]
	public uint DataInt02 { get; set; }

	[TableColumn("dataInt03")]
	public uint DataInt03 { get; set; }

	[TableColumn("dataInt04")]
	public uint DataInt04 { get; set; }

	[TableColumn("dataFloat00")]
	public float DataFloat00 { get; set; }

	[TableColumn("dataFloat01")]
	public float DataFloat01 { get; set; }

	[TableColumn("dataFloat02")]
	public float DataFloat02 { get; set; }

	[TableColumn("dataFloat03")]
	public float DataFloat03 { get; set; }

	[TableColumn("dataFloat04")]
	public float DataFloat04 { get; set; }
}
