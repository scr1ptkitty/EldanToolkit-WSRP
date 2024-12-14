using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SkyTrackCloudSetRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("count")]
	public uint Count { get; set; }

	[TableColumn("minSize00")]
	public float MinSize00 { get; set; }

	[TableColumn("minSize01")]
	public float MinSize01 { get; set; }

	[TableColumn("minSize02")]
	public float MinSize02 { get; set; }

	[TableColumn("minSize03")]
	public float MinSize03 { get; set; }

	[TableColumn("minSize04")]
	public float MinSize04 { get; set; }

	[TableColumn("minSize05")]
	public float MinSize05 { get; set; }

	[TableColumn("minSize06")]
	public float MinSize06 { get; set; }

	[TableColumn("minSize07")]
	public float MinSize07 { get; set; }

	[TableColumn("minSize08")]
	public float MinSize08 { get; set; }

	[TableColumn("minSize09")]
	public float MinSize09 { get; set; }

	[TableColumn("minSize10")]
	public float MinSize10 { get; set; }

	[TableColumn("minSize11")]
	public float MinSize11 { get; set; }

	[TableColumn("maxSize00")]
	public float MaxSize00 { get; set; }

	[TableColumn("maxSize01")]
	public float MaxSize01 { get; set; }

	[TableColumn("maxSize02")]
	public float MaxSize02 { get; set; }

	[TableColumn("maxSize03")]
	public float MaxSize03 { get; set; }

	[TableColumn("maxSize04")]
	public float MaxSize04 { get; set; }

	[TableColumn("maxSize05")]
	public float MaxSize05 { get; set; }

	[TableColumn("maxSize06")]
	public float MaxSize06 { get; set; }

	[TableColumn("maxSize07")]
	public float MaxSize07 { get; set; }

	[TableColumn("maxSize08")]
	public float MaxSize08 { get; set; }

	[TableColumn("maxSize09")]
	public float MaxSize09 { get; set; }

	[TableColumn("maxSize10")]
	public float MaxSize10 { get; set; }

	[TableColumn("maxSize11")]
	public float MaxSize11 { get; set; }

	[TableColumn("model00")]
	public string Model00 { get; set; } = string.Empty;

	[TableColumn("model01")]
	public string Model01 { get; set; } = string.Empty;

	[TableColumn("model02")]
	public string Model02 { get; set; } = string.Empty;

	[TableColumn("model03")]
	public string Model03 { get; set; } = string.Empty;

	[TableColumn("model04")]
	public string Model04 { get; set; } = string.Empty;

	[TableColumn("model05")]
	public string Model05 { get; set; } = string.Empty;

	[TableColumn("model06")]
	public string Model06 { get; set; } = string.Empty;

	[TableColumn("model07")]
	public string Model07 { get; set; } = string.Empty;

	[TableColumn("model08")]
	public string Model08 { get; set; } = string.Empty;

	[TableColumn("model09")]
	public string Model09 { get; set; } = string.Empty;

	[TableColumn("model10")]
	public string Model10 { get; set; } = string.Empty;

	[TableColumn("model11")]
	public string Model11 { get; set; } = string.Empty;
}
