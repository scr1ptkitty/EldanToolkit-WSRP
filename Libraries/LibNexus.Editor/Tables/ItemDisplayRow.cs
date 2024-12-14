using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemDisplayRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("item2TypeId")]
	public uint Item2TypeId { get; set; }

	[TableColumn("objectModel")]
	public string ObjectModel { get; set; } = string.Empty;

	[TableColumn("objectModelL")]
	public string ObjectModelL { get; set; } = string.Empty;

	[TableColumn("objectTexture0")]
	public string ObjectTexture0 { get; set; } = string.Empty;

	[TableColumn("objectTexture1")]
	public string ObjectTexture1 { get; set; } = string.Empty;

	[TableColumn("modelTextureIdObject00")]
	public uint ModelTextureIdObject00 { get; set; }

	[TableColumn("modelTextureIdObject01")]
	public uint ModelTextureIdObject01 { get; set; }

	[TableColumn("skinnedModel")]
	public string SkinnedModel { get; set; } = string.Empty;

	[TableColumn("skinnedModelL")]
	public string SkinnedModelL { get; set; } = string.Empty;

	[TableColumn("skinnedTexture0")]
	public string SkinnedTexture0 { get; set; } = string.Empty;

	[TableColumn("skinnedTexture1")]
	public string SkinnedTexture1 { get; set; } = string.Empty;

	[TableColumn("modelTextureIdSkinned00")]
	public uint ModelTextureIdSkinned00 { get; set; }

	[TableColumn("modelTextureIdSkinned01")]
	public uint ModelTextureIdSkinned01 { get; set; }

	[TableColumn("attachedModel")]
	public string AttachedModel { get; set; } = string.Empty;

	[TableColumn("modelAttachmentIdAttached")]
	public uint ModelAttachmentIdAttached { get; set; }

	[TableColumn("attachedTexture0")]
	public string AttachedTexture0 { get; set; } = string.Empty;

	[TableColumn("attachedTexture1")]
	public string AttachedTexture1 { get; set; } = string.Empty;

	[TableColumn("modelTextureIdAttached00")]
	public uint ModelTextureIdAttached00 { get; set; }

	[TableColumn("modelTextureIdAttached01")]
	public uint ModelTextureIdAttached01 { get; set; }

	[TableColumn("componentRegionFlags")]
	public uint ComponentRegionFlags { get; set; }

	[TableColumn("componentPriority")]
	public uint ComponentPriority { get; set; }

	[TableColumn("skinMaskMap")]
	public string SkinMaskMap { get; set; } = string.Empty;

	[TableColumn("skinColorMap")]
	public string SkinColorMap { get; set; } = string.Empty;

	[TableColumn("skinNormalMap")]
	public string SkinNormalMap { get; set; } = string.Empty;

	[TableColumn("skinDyeMap")]
	public string SkinDyeMap { get; set; } = string.Empty;

	[TableColumn("armorMaskMap")]
	public string ArmorMaskMap { get; set; } = string.Empty;

	[TableColumn("armorColorMap")]
	public string ArmorColorMap { get; set; } = string.Empty;

	[TableColumn("armorNormalMap")]
	public string ArmorNormalMap { get; set; } = string.Empty;

	[TableColumn("armorDyeMap")]
	public string ArmorDyeMap { get; set; } = string.Empty;

	[TableColumn("modelMeshId00")]
	public uint ModelMeshId00 { get; set; }

	[TableColumn("modelMeshId01")]
	public uint ModelMeshId01 { get; set; }

	[TableColumn("modelMeshId02")]
	public uint ModelMeshId02 { get; set; }

	[TableColumn("modelMeshId03")]
	public uint ModelMeshId03 { get; set; }

	[TableColumn("soundImpactDescriptionId")]
	public uint SoundImpactDescriptionId { get; set; }

	[TableColumn("ItemVisualTypeId")]
	public uint ItemVisualTypeId { get; set; }

	[TableColumn("soundReplaceDescriptionId")]
	public uint SoundReplaceDescriptionId { get; set; }

	[TableColumn("itemColorSetId")]
	public uint ItemColorSetId { get; set; }

	[TableColumn("dyeChannelFlags")]
	public uint DyeChannelFlags { get; set; }

	[TableColumn("modelPoseId")]
	public uint ModelPoseId { get; set; }

	[TableColumn("modelPoseBlend")]
	public float ModelPoseBlend { get; set; }

	[TableColumn("shaderPreset00")]
	public uint ShaderPreset00 { get; set; }

	[TableColumn("shaderPreset01")]
	public uint ShaderPreset01 { get; set; }
}
