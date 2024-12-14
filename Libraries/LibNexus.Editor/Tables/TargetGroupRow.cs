using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TargetGroupRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdDisplayString")]
	public uint LocalizedTextIdDisplayString { get; set; }

	[TableColumn("type")]
	public uint Type { get; set; }

	[TableColumn("data0")]
	public uint Data0 { get; set; }

	[TableColumn("data1")]
	public uint Data1 { get; set; }

	[TableColumn("data2")]
	public uint Data2 { get; set; }

	[TableColumn("data3")]
	public uint Data3 { get; set; }

	[TableColumn("data4")]
	public uint Data4 { get; set; }

	[TableColumn("data5")]
	public uint Data5 { get; set; }

	[TableColumn("data6")]
	public uint Data6 { get; set; }
}
