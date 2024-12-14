using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SpellEffectTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("dataType00")]
	public uint DataType00 { get; set; }

	[TableColumn("dataType01")]
	public uint DataType01 { get; set; }

	[TableColumn("dataType02")]
	public uint DataType02 { get; set; }

	[TableColumn("dataType03")]
	public uint DataType03 { get; set; }

	[TableColumn("dataType04")]
	public uint DataType04 { get; set; }

	[TableColumn("dataType05")]
	public uint DataType05 { get; set; }

	[TableColumn("dataType06")]
	public uint DataType06 { get; set; }

	[TableColumn("dataType07")]
	public uint DataType07 { get; set; }

	[TableColumn("dataType08")]
	public uint DataType08 { get; set; }

	[TableColumn("dataType09")]
	public uint DataType09 { get; set; }
}
