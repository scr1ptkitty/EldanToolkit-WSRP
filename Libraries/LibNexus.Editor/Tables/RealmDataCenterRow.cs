using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RealmDataCenterRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("deploymentRegionEnum")]
	public uint DeploymentRegionEnum { get; set; }

	[TableColumn("deploymentTypeEnum")]
	public uint DeploymentTypeEnum { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("authServer")]
	public string AuthServer { get; set; } = string.Empty;

	[TableColumn("ncClientAuthServer")]
	public string NcClientAuthServer { get; set; } = string.Empty;

	[TableColumn("ncRedirectUrlTemplate")]
	public string NcRedirectUrlTemplate { get; set; } = string.Empty;

	[TableColumn("ncRedirectUrlTemplateSignature")]
	public string NcRedirectUrlTemplateSignature { get; set; } = string.Empty;

	[TableColumn("ncAppGroupCode")]
	public string NcAppGroupCode { get; set; } = string.Empty;

	[TableColumn("ncProgramAuth")]
	public uint NcProgramAuth { get; set; }

	[TableColumn("steamSignatureUrlTemplate")]
	public string SteamSignatureUrlTemplate { get; set; } = string.Empty;

	[TableColumn("steamNCoinUrlTemplate")]
	public string SteamNCoinUrlTemplate { get; set; } = string.Empty;

	[TableColumn("storeBannerDataUrlTemplate")]
	public string StoreBannerDataUrlTemplate { get; set; } = string.Empty;
}
