using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class DatacubeVolumeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("assetPath")]
	public string AssetPath { get; set; } = string.Empty;

	[TableColumn("datacubeId00")]
	public uint DatacubeId00 { get; set; }

	[TableColumn("datacubeId01")]
	public uint DatacubeId01 { get; set; }

	[TableColumn("datacubeId02")]
	public uint DatacubeId02 { get; set; }

	[TableColumn("datacubeId03")]
	public uint DatacubeId03 { get; set; }

	[TableColumn("datacubeId04")]
	public uint DatacubeId04 { get; set; }

	[TableColumn("datacubeId05")]
	public uint DatacubeId05 { get; set; }

	[TableColumn("datacubeId06")]
	public uint DatacubeId06 { get; set; }

	[TableColumn("datacubeId07")]
	public uint DatacubeId07 { get; set; }

	[TableColumn("datacubeId08")]
	public uint DatacubeId08 { get; set; }

	[TableColumn("datacubeId09")]
	public uint DatacubeId09 { get; set; }

	[TableColumn("datacubeId10")]
	public uint DatacubeId10 { get; set; }

	[TableColumn("datacubeId11")]
	public uint DatacubeId11 { get; set; }

	[TableColumn("datacubeId12")]
	public uint DatacubeId12 { get; set; }

	[TableColumn("datacubeId13")]
	public uint DatacubeId13 { get; set; }

	[TableColumn("datacubeId14")]
	public uint DatacubeId14 { get; set; }

	[TableColumn("datacubeId15")]
	public uint DatacubeId15 { get; set; }
}
