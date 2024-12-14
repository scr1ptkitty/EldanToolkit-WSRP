using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EldanAugmentationRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("displayRow")]
	public uint DisplayRow { get; set; }

	[TableColumn("displayColumn")]
	public uint DisplayColumn { get; set; }

	[TableColumn("classId")]
	public uint ClassId { get; set; }

	[TableColumn("powerCost")]
	public uint PowerCost { get; set; }

	[TableColumn("eldanAugmentationIdRequired")]
	public uint EldanAugmentationIdRequired { get; set; }

	[TableColumn("spell4IdAugment")]
	public uint Spell4IdAugment { get; set; }

	[TableColumn("item2IdUnlock")]
	public uint Item2IdUnlock { get; set; }

	[TableColumn("eldanAugmentationCategoryId")]
	public uint EldanAugmentationCategoryId { get; set; }

	[TableColumn("categoryTier")]
	public uint CategoryTier { get; set; }

	[TableColumn("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[TableColumn("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }
}
