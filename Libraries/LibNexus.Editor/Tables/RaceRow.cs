using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RaceRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("localizedTextIdNameFemale")]
	public uint LocalizedTextIdNameFemale { get; set; }

	[TableColumn("maleAssetPath")]
	public string MaleAssetPath { get; set; } = string.Empty;

	[TableColumn("femaleAssetPath")]
	public string FemaleAssetPath { get; set; } = string.Empty;

	[TableColumn("hitRadius")]
	public float HitRadius { get; set; }

	[TableColumn("soundImpactDescriptionIdOrigin")]
	public uint SoundImpactDescriptionIdOrigin { get; set; }

	[TableColumn("soundImpactDescriptionIdTarget")]
	public uint SoundImpactDescriptionIdTarget { get; set; }

	[TableColumn("walkLand")]
	public float WalkLand { get; set; }

	[TableColumn("walkAir")]
	public float WalkAir { get; set; }

	[TableColumn("walkWater")]
	public float WalkWater { get; set; }

	[TableColumn("walkHover")]
	public float WalkHover { get; set; }

	[TableColumn("unitVisualTypeIdMale")]
	public uint UnitVisualTypeIdMale { get; set; }

	[TableColumn("unitVisualTypeIdFemale")]
	public uint UnitVisualTypeIdFemale { get; set; }

	[TableColumn("soundEventIdMaleHealthStart")]
	public uint SoundEventIdMaleHealthStart { get; set; }

	[TableColumn("soundEventIdFemaleHealthStart")]
	public uint SoundEventIdFemaleHealthStart { get; set; }

	[TableColumn("soundEventIdMaleHealthStop")]
	public uint SoundEventIdMaleHealthStop { get; set; }

	[TableColumn("soundEventIdFemaleHealthStop")]
	public uint SoundEventIdFemaleHealthStop { get; set; }

	[TableColumn("swimWaterDepth")]
	public float SwimWaterDepth { get; set; }

	[TableColumn("itemDisplayIdUnderwearLegsMale")]
	public uint ItemDisplayIdUnderwearLegsMale { get; set; }

	[TableColumn("itemDisplayIdUnderwearLegsFemale")]
	public uint ItemDisplayIdUnderwearLegsFemale { get; set; }

	[TableColumn("itemDisplayIdUnderwearChestFemale")]
	public uint ItemDisplayIdUnderwearChestFemale { get; set; }

	[TableColumn("itemDisplayIdArmCannon")]
	public uint ItemDisplayIdArmCannon { get; set; }

	[TableColumn("mountScaleMale")]
	public float MountScaleMale { get; set; }

	[TableColumn("mountScaleFemale")]
	public float MountScaleFemale { get; set; }

	[TableColumn("soundSwitchId")]
	public uint SoundSwitchId { get; set; }

	[TableColumn("componentLayoutIdMale")]
	public uint ComponentLayoutIdMale { get; set; }

	[TableColumn("componentLayoutIdFemale")]
	public uint ComponentLayoutIdFemale { get; set; }

	[TableColumn("modelMeshIdMountItemMale")]
	public uint ModelMeshIdMountItemMale { get; set; }

	[TableColumn("modelMeshIdMountItemFemale")]
	public uint ModelMeshIdMountItemFemale { get; set; }
}
