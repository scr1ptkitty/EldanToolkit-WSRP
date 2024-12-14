using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SkyCloudSetRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("density")]
	public float Density { get; set; }

	[TableColumn("skyTrackCloudSetId00")]
	public uint SkyTrackCloudSetId00 { get; set; }

	[TableColumn("skyTrackCloudSetId01")]
	public uint SkyTrackCloudSetId01 { get; set; }

	[TableColumn("skyTrackCloudSetId02")]
	public uint SkyTrackCloudSetId02 { get; set; }

	[TableColumn("skyTrackCloudSetId03")]
	public uint SkyTrackCloudSetId03 { get; set; }

	[TableColumn("skyTrackCloudSetId04")]
	public uint SkyTrackCloudSetId04 { get; set; }

	[TableColumn("skyTrackCloudSetId05")]
	public uint SkyTrackCloudSetId05 { get; set; }
}
