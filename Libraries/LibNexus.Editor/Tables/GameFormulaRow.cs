using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GameFormulaRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("dataint0")]
	public uint Dataint0 { get; set; }

	[TableColumn("dataint01")]
	public uint Dataint01 { get; set; }

	[TableColumn("dataint02")]
	public uint Dataint02 { get; set; }

	[TableColumn("dataint03")]
	public uint Dataint03 { get; set; }

	[TableColumn("dataint04")]
	public uint Dataint04 { get; set; }

	[TableColumn("datafloat0")]
	public float Datafloat0 { get; set; }

	[TableColumn("datafloat01")]
	public float Datafloat01 { get; set; }

	[TableColumn("datafloat02")]
	public float Datafloat02 { get; set; }

	[TableColumn("datafloat03")]
	public float Datafloat03 { get; set; }

	[TableColumn("datafloat04")]
	public float Datafloat04 { get; set; }
}
