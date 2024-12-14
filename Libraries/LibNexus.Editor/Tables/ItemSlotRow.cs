using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemSlotRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("EnumName")]
	public string EnumName { get; set; } = string.Empty;

	[TableColumn("equippedSlotFlags")]
	public uint EquippedSlotFlags { get; set; }

	[TableColumn("armorModifier")]
	public float ArmorModifier { get; set; }

	[TableColumn("itemLevelModifier")]
	public float ItemLevelModifier { get; set; }

	[TableColumn("slotBonus")]
	public uint SlotBonus { get; set; }

	[TableColumn("glyphSlotBonus")]
	public uint GlyphSlotBonus { get; set; }

	[TableColumn("minLevel")]
	public uint MinLevel { get; set; }
}
