using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Item2Row
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("itemBudgetId")]
	public uint ItemBudgetId { get; set; }

	[TableColumn("itemStatId")]
	public uint ItemStatId { get; set; }

	[TableColumn("itemRuneInstanceId")]
	public uint ItemRuneInstanceId { get; set; }

	[TableColumn("itemQualityId")]
	public uint ItemQualityId { get; set; }

	[TableColumn("itemSpecialId00")]
	public uint ItemSpecialId00 { get; set; }

	[TableColumn("itemImbuementId")]
	public uint ItemImbuementId { get; set; }

	[TableColumn("item2FamilyId")]
	public uint Item2FamilyId { get; set; }

	[TableColumn("item2CategoryId")]
	public uint Item2CategoryId { get; set; }

	[TableColumn("item2TypeId")]
	public uint Item2TypeId { get; set; }

	[TableColumn("itemDisplayId")]
	public uint ItemDisplayId { get; set; }

	[TableColumn("itemSourceId")]
	public uint ItemSourceId { get; set; }

	[TableColumn("classRequired")]
	public uint ClassRequired { get; set; }

	[TableColumn("raceRequired")]
	public uint RaceRequired { get; set; }

	[TableColumn("faction2IdRequired")]
	public uint Faction2IdRequired { get; set; }

	[TableColumn("powerLevel")]
	public uint PowerLevel { get; set; }

	[TableColumn("requiredLevel")]
	public uint RequiredLevel { get; set; }

	[TableColumn("requiredItemLevel")]
	public uint RequiredItemLevel { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("equippedSlotFlags")]
	public uint EquippedSlotFlags { get; set; }

	[TableColumn("maxStackCount")]
	public uint MaxStackCount { get; set; }

	[TableColumn("maxCharges")]
	public uint MaxCharges { get; set; }

	[TableColumn("expirationTimeMinutes")]
	public uint ExpirationTimeMinutes { get; set; }

	[TableColumn("quest2IdActivation")]
	public uint Quest2IdActivation { get; set; }

	[TableColumn("quest2IdActivationRequired")]
	public uint Quest2IdActivationRequired { get; set; }

	[TableColumn("questObjectiveActivationRequired")]
	public uint QuestObjectiveActivationRequired { get; set; }

	[TableColumn("tradeskillAdditiveId")]
	public uint TradeskillAdditiveId { get; set; }

	[TableColumn("tradeskillCatalystId")]
	public uint TradeskillCatalystId { get; set; }

	[TableColumn("housingDecorInfoId")]
	public uint HousingDecorInfoId { get; set; }

	[TableColumn("housingWarplotBossTokenId")]
	public uint HousingWarplotBossTokenId { get; set; }

	[TableColumn("genericUnlockSetId")]
	public uint GenericUnlockSetId { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("bindFlags")]
	public uint BindFlags { get; set; }

	[TableColumn("buyFromVendorStackCount")]
	public uint BuyFromVendorStackCount { get; set; }

	[TableColumn("currencyTypeId0")]
	public uint CurrencyTypeId0 { get; set; }

	[TableColumn("currencyTypeId1")]
	public uint CurrencyTypeId1 { get; set; }

	[TableColumn("currencyAmount0")]
	public uint CurrencyAmount0 { get; set; }

	[TableColumn("currencyAmount1")]
	public uint CurrencyAmount1 { get; set; }

	[TableColumn("currencyTypeId0SellToVendor")]
	public uint CurrencyTypeId0SellToVendor { get; set; }

	[TableColumn("currencyTypeId1SellToVendor")]
	public uint CurrencyTypeId1SellToVendor { get; set; }

	[TableColumn("currencyAmount0SellToVendor")]
	public uint CurrencyAmount0SellToVendor { get; set; }

	[TableColumn("currencyAmount1SellToVendor")]
	public uint CurrencyAmount1SellToVendor { get; set; }

	[TableColumn("itemColorSetId")]
	public uint ItemColorSetId { get; set; }

	[TableColumn("supportPowerPercentage")]
	public float SupportPowerPercentage { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[TableColumn("buttonTemplate")]
	public string ButtonTemplate { get; set; } = string.Empty;

	[TableColumn("buttonIcon")]
	public string ButtonIcon { get; set; } = string.Empty;

	[TableColumn("soundEventIdEquip")]
	public uint SoundEventIdEquip { get; set; }
}
