using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Item2CategoryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("itemProficiencyId")]
	public uint ItemProficiencyId { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("tradeSkillId")]
	public uint TradeSkillId { get; set; }

	[TableColumn("soundEventIdEquip")]
	public uint SoundEventIdEquip { get; set; }

	[TableColumn("vendorMultiplier")]
	public float VendorMultiplier { get; set; }

	[TableColumn("turninMultiplier")]
	public float TurninMultiplier { get; set; }

	[TableColumn("armorModifier")]
	public float ArmorModifier { get; set; }

	[TableColumn("armorBase")]
	public float ArmorBase { get; set; }

	[TableColumn("weaponPowerModifier")]
	public float WeaponPowerModifier { get; set; }

	[TableColumn("weaponPowerBase")]
	public uint WeaponPowerBase { get; set; }

	[TableColumn("item2FamilyId")]
	public uint Item2FamilyId { get; set; }
}
