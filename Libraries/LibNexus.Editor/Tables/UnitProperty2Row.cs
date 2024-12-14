using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class UnitProperty2Row
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[TableColumn("defaultValue")]
	public float DefaultValue { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("valuePerPoint")]
	public float ValuePerPoint { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("tooltipDisplayOrder")]
	public uint TooltipDisplayOrder { get; set; }

	[TableColumn("profiencyFlagEnum")]
	public uint ProfiencyFlagEnum { get; set; }

	[TableColumn("itemCraftingGroupFlagBitMask")]
	public uint ItemCraftingGroupFlagBitMask { get; set; }

	[TableColumn("equippedSlotFlags")]
	public uint EquippedSlotFlags { get; set; }
}
