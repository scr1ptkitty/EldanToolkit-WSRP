using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EldanAugmentationCategoryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("eldanAugmentationCategoryIdTier2Category00")]
	public uint EldanAugmentationCategoryIdTier2Category00 { get; set; }

	[TableColumn("eldanAugmentationCategoryIdTier2Category01")]
	public uint EldanAugmentationCategoryIdTier2Category01 { get; set; }

	[TableColumn("tier2CostAmount00")]
	public uint Tier2CostAmount00 { get; set; }

	[TableColumn("tier2CostAmount01")]
	public uint Tier2CostAmount01 { get; set; }

	[TableColumn("tier3CostAmount00")]
	public uint Tier3CostAmount00 { get; set; }

	[TableColumn("tier3CostAmount01")]
	public uint Tier3CostAmount01 { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }
}
