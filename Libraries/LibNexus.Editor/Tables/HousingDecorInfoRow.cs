using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingDecorInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("housingDecorTypeId")]
	public uint HousingDecorTypeId { get; set; }

	[TableColumn("hookTypeId")]
	public uint HookTypeId { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("hookAssetId")]
	public uint HookAssetId { get; set; }

	[TableColumn("cost")]
	public uint Cost { get; set; }

	[TableColumn("costCurrencyTypeId")]
	public uint CostCurrencyTypeId { get; set; }

	[TableColumn("creature2IdActiveProp")]
	public uint Creature2IdActiveProp { get; set; }

	[TableColumn("prerequisiteIdUnlock")]
	public uint PrerequisiteIdUnlock { get; set; }

	[TableColumn("spell4IdInteriorBuff")]
	public uint Spell4IdInteriorBuff { get; set; }

	[TableColumn("housingDecorLimitCategoryId")]
	public uint HousingDecorLimitCategoryId { get; set; }

	[TableColumn("altPreviewAsset")]
	public string AltPreviewAsset { get; set; } = string.Empty;

	[TableColumn("altEditAsset")]
	public string AltEditAsset { get; set; } = string.Empty;

	[TableColumn("minScale")]
	public float MinScale { get; set; }

	[TableColumn("maxScale")]
	public float MaxScale { get; set; }
}
