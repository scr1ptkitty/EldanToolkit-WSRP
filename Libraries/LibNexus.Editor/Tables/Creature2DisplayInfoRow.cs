using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2DisplayInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("statusFlags")]
	public uint StatusFlags { get; set; }

	[TableColumn("assetPath")]
	public string AssetPath { get; set; } = string.Empty;

	[TableColumn("assetTexture00")]
	public string AssetTexture00 { get; set; } = string.Empty;

	[TableColumn("assetTexture01")]
	public string AssetTexture01 { get; set; } = string.Empty;

	[TableColumn("assetTexture02")]
	public string AssetTexture02 { get; set; } = string.Empty;

	[TableColumn("assetTexture03")]
	public string AssetTexture03 { get; set; } = string.Empty;

	[TableColumn("assetTexture04")]
	public string AssetTexture04 { get; set; } = string.Empty;

	[TableColumn("assetTexture05")]
	public string AssetTexture05 { get; set; } = string.Empty;

	[TableColumn("modelTextureId00")]
	public uint ModelTextureId00 { get; set; }

	[TableColumn("modelTextureId01")]
	public uint ModelTextureId01 { get; set; }

	[TableColumn("modelTextureId02")]
	public uint ModelTextureId02 { get; set; }

	[TableColumn("modelTextureId03")]
	public uint ModelTextureId03 { get; set; }

	[TableColumn("modelTextureId04")]
	public uint ModelTextureId04 { get; set; }

	[TableColumn("modelTextureId05")]
	public uint ModelTextureId05 { get; set; }

	[TableColumn("colorShiftTexturePath")]
	public string ColorShiftTexturePath { get; set; } = string.Empty;

	[TableColumn("colorShiftTextureIdMask")]
	public uint ColorShiftTextureIdMask { get; set; }

	[TableColumn("materialDataIdSkinColor0")]
	public uint MaterialDataIdSkinColor0 { get; set; }

	[TableColumn("materialDataIdSkinColor1")]
	public uint MaterialDataIdSkinColor1 { get; set; }

	[TableColumn("materialDataIdWeaponColor0")]
	public uint MaterialDataIdWeaponColor0 { get; set; }

	[TableColumn("materialDataIdWeaponColor1")]
	public uint MaterialDataIdWeaponColor1 { get; set; }

	[TableColumn("materialDataIdArmorColor0")]
	public uint MaterialDataIdArmorColor0 { get; set; }

	[TableColumn("materialDataIdArmorColor1")]
	public uint MaterialDataIdArmorColor1 { get; set; }

	[TableColumn("materialDataIdDefault0")]
	public uint MaterialDataIdDefault0 { get; set; }

	[TableColumn("materialDataIdDefault1")]
	public uint MaterialDataIdDefault1 { get; set; }

	[TableColumn("creatureMaterialEnum")]
	public uint CreatureMaterialEnum { get; set; }

	[TableColumn("scale")]
	public float Scale { get; set; }

	[TableColumn("hitRadius")]
	public float HitRadius { get; set; }

	[TableColumn("walkLand")]
	public float WalkLand { get; set; }

	[TableColumn("walkAir")]
	public float WalkAir { get; set; }

	[TableColumn("walkWater")]
	public float WalkWater { get; set; }

	[TableColumn("walkHover")]
	public float WalkHover { get; set; }

	[TableColumn("runLand")]
	public float RunLand { get; set; }

	[TableColumn("runAir")]
	public float RunAir { get; set; }

	[TableColumn("runWater")]
	public float RunWater { get; set; }

	[TableColumn("runHover")]
	public float RunHover { get; set; }

	[TableColumn("itemVisualTypeIdFeet")]
	public uint ItemVisualTypeIdFeet { get; set; }

	[TableColumn("swimWaterDepth")]
	public float SwimWaterDepth { get; set; }

	[TableColumn("raceId")]
	public uint RaceId { get; set; }

	[TableColumn("sex")]
	public uint Sex { get; set; }

	[TableColumn("itemDisplayId00")]
	public uint ItemDisplayId00 { get; set; }

	[TableColumn("itemDisplayId01")]
	public uint ItemDisplayId01 { get; set; }

	[TableColumn("itemDisplayId02")]
	public uint ItemDisplayId02 { get; set; }

	[TableColumn("itemDisplayId03")]
	public uint ItemDisplayId03 { get; set; }

	[TableColumn("itemDisplayId04")]
	public uint ItemDisplayId04 { get; set; }

	[TableColumn("itemDisplayId05")]
	public uint ItemDisplayId05 { get; set; }

	[TableColumn("itemDisplayId06")]
	public uint ItemDisplayId06 { get; set; }

	[TableColumn("itemDisplayId07")]
	public uint ItemDisplayId07 { get; set; }

	[TableColumn("itemDisplayId08")]
	public uint ItemDisplayId08 { get; set; }

	[TableColumn("itemDisplayId09")]
	public uint ItemDisplayId09 { get; set; }

	[TableColumn("itemDisplayId10")]
	public uint ItemDisplayId10 { get; set; }

	[TableColumn("itemDisplayId11")]
	public uint ItemDisplayId11 { get; set; }

	[TableColumn("itemDisplayId12")]
	public uint ItemDisplayId12 { get; set; }

	[TableColumn("itemDisplayId13")]
	public uint ItemDisplayId13 { get; set; }

	[TableColumn("itemDisplayId14")]
	public uint ItemDisplayId14 { get; set; }

	[TableColumn("itemDisplayId15")]
	public uint ItemDisplayId15 { get; set; }

	[TableColumn("itemDisplayId16")]
	public uint ItemDisplayId16 { get; set; }

	[TableColumn("itemDisplayId17")]
	public uint ItemDisplayId17 { get; set; }

	[TableColumn("itemDisplayId18")]
	public uint ItemDisplayId18 { get; set; }

	[TableColumn("itemDisplayId19")]
	public uint ItemDisplayId19 { get; set; }

	[TableColumn("modelMeshId00")]
	public uint ModelMeshId00 { get; set; }

	[TableColumn("modelMeshId01")]
	public uint ModelMeshId01 { get; set; }

	[TableColumn("modelMeshId02")]
	public uint ModelMeshId02 { get; set; }

	[TableColumn("modelMeshId03")]
	public uint ModelMeshId03 { get; set; }

	[TableColumn("modelMeshId04")]
	public uint ModelMeshId04 { get; set; }

	[TableColumn("modelMeshId05")]
	public uint ModelMeshId05 { get; set; }

	[TableColumn("modelMeshId06")]
	public uint ModelMeshId06 { get; set; }

	[TableColumn("modelMeshId07")]
	public uint ModelMeshId07 { get; set; }

	[TableColumn("modelMeshId08")]
	public uint ModelMeshId08 { get; set; }

	[TableColumn("modelMeshId09")]
	public uint ModelMeshId09 { get; set; }

	[TableColumn("modelMeshId10")]
	public uint ModelMeshId10 { get; set; }

	[TableColumn("modelMeshId11")]
	public uint ModelMeshId11 { get; set; }

	[TableColumn("modelMeshId12")]
	public uint ModelMeshId12 { get; set; }

	[TableColumn("modelMeshId13")]
	public uint ModelMeshId13 { get; set; }

	[TableColumn("modelMeshId14")]
	public uint ModelMeshId14 { get; set; }

	[TableColumn("modelMeshId15")]
	public uint ModelMeshId15 { get; set; }

	[TableColumn("groundOffsetHover")]
	public float GroundOffsetHover { get; set; }

	[TableColumn("groundOffsetFly")]
	public float GroundOffsetFly { get; set; }
}
