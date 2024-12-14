using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldClutterRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("Description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("density")]
	public float Density { get; set; }

	[TableColumn("clutterFlags")]
	public uint ClutterFlags { get; set; }

	[TableColumn("assetPath0")]
	public string AssetPath0 { get; set; } = string.Empty;

	[TableColumn("assetPath01")]
	public string AssetPath01 { get; set; } = string.Empty;

	[TableColumn("assetPath02")]
	public string AssetPath02 { get; set; } = string.Empty;

	[TableColumn("assetPath03")]
	public string AssetPath03 { get; set; } = string.Empty;

	[TableColumn("assetPath04")]
	public string AssetPath04 { get; set; } = string.Empty;

	[TableColumn("assetPath05")]
	public string AssetPath05 { get; set; } = string.Empty;

	[TableColumn("assetWeight0")]
	public float AssetWeight0 { get; set; }

	[TableColumn("assetWeight01")]
	public float AssetWeight01 { get; set; }

	[TableColumn("assetWeight02")]
	public float AssetWeight02 { get; set; }

	[TableColumn("assetWeight03")]
	public float AssetWeight03 { get; set; }

	[TableColumn("assetWeight04")]
	public float AssetWeight04 { get; set; }

	[TableColumn("assetWeight05")]
	public float AssetWeight05 { get; set; }

	[TableColumn("flag0")]
	public uint Flag0 { get; set; }

	[TableColumn("flag01")]
	public uint Flag01 { get; set; }

	[TableColumn("flag02")]
	public uint Flag02 { get; set; }

	[TableColumn("flag03")]
	public uint Flag03 { get; set; }

	[TableColumn("flag04")]
	public uint Flag04 { get; set; }

	[TableColumn("flag05")]
	public uint Flag05 { get; set; }

	[TableColumn("minScale0")]
	public float MinScale0 { get; set; }

	[TableColumn("minScale01")]
	public float MinScale01 { get; set; }

	[TableColumn("minScale02")]
	public float MinScale02 { get; set; }

	[TableColumn("minScale03")]
	public float MinScale03 { get; set; }

	[TableColumn("minScale04")]
	public float MinScale04 { get; set; }

	[TableColumn("minScale05")]
	public float MinScale05 { get; set; }

	[TableColumn("rotationMin0")]
	public float RotationMin0 { get; set; }

	[TableColumn("rotationMin01")]
	public float RotationMin01 { get; set; }

	[TableColumn("rotationMin02")]
	public float RotationMin02 { get; set; }

	[TableColumn("rotationMin03")]
	public float RotationMin03 { get; set; }

	[TableColumn("rotationMin04")]
	public float RotationMin04 { get; set; }

	[TableColumn("rotationMin05")]
	public float RotationMin05 { get; set; }

	[TableColumn("rotationMax0")]
	public float RotationMax0 { get; set; }

	[TableColumn("rotationMax01")]
	public float RotationMax01 { get; set; }

	[TableColumn("rotationMax02")]
	public float RotationMax02 { get; set; }

	[TableColumn("rotationMax03")]
	public float RotationMax03 { get; set; }

	[TableColumn("rotationMax04")]
	public float RotationMax04 { get; set; }

	[TableColumn("rotationMax05")]
	public float RotationMax05 { get; set; }

	[TableColumn("emissiveGlow00")]
	public uint EmissiveGlow00 { get; set; }

	[TableColumn("emissiveGlow01")]
	public uint EmissiveGlow01 { get; set; }

	[TableColumn("emissiveGlow02")]
	public uint EmissiveGlow02 { get; set; }

	[TableColumn("emissiveGlow03")]
	public uint EmissiveGlow03 { get; set; }

	[TableColumn("emissiveGlow04")]
	public uint EmissiveGlow04 { get; set; }

	[TableColumn("emissiveGlow05")]
	public uint EmissiveGlow05 { get; set; }
}
