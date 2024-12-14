using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterCreationRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("classId")]
	public uint ClassId { get; set; }

	[TableColumn("raceId")]
	public uint RaceId { get; set; }

	[TableColumn("sex")]
	public uint Sex { get; set; }

	[TableColumn("factionId")]
	public uint FactionId { get; set; }

	[TableColumn("costumeOnly")]
	public bool CostumeOnly { get; set; }

	[TableColumn("itemId0")]
	public uint ItemId0 { get; set; }

	[TableColumn("itemId01")]
	public uint ItemId01 { get; set; }

	[TableColumn("itemId02")]
	public uint ItemId02 { get; set; }

	[TableColumn("itemId03")]
	public uint ItemId03 { get; set; }

	[TableColumn("itemId04")]
	public uint ItemId04 { get; set; }

	[TableColumn("itemId05")]
	public uint ItemId05 { get; set; }

	[TableColumn("itemId06")]
	public uint ItemId06 { get; set; }

	[TableColumn("itemId07")]
	public uint ItemId07 { get; set; }

	[TableColumn("itemId08")]
	public uint ItemId08 { get; set; }

	[TableColumn("itemId09")]
	public uint ItemId09 { get; set; }

	[TableColumn("itemId010")]
	public uint ItemId010 { get; set; }

	[TableColumn("itemId011")]
	public uint ItemId011 { get; set; }

	[TableColumn("itemId012")]
	public uint ItemId012 { get; set; }

	[TableColumn("itemId013")]
	public uint ItemId013 { get; set; }

	[TableColumn("itemId014")]
	public uint ItemId014 { get; set; }

	[TableColumn("itemId015")]
	public uint ItemId015 { get; set; }

	[TableColumn("enabled")]
	public bool Enabled { get; set; }

	[TableColumn("characterCreationStartEnum")]
	public uint CharacterCreationStartEnum { get; set; }

	[TableColumn("xp")]
	public uint Xp { get; set; }

	[TableColumn("accountCurrencyTypeIdCost")]
	public uint AccountCurrencyTypeIdCost { get; set; }

	[TableColumn("accountCurrencyAmountCost")]
	public uint AccountCurrencyAmountCost { get; set; }

	[TableColumn("entitlementIdRequired")]
	public uint EntitlementIdRequired { get; set; }
}
