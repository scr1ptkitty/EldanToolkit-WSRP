using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AccountItemRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("item2Id")]
	public uint Item2Id { get; set; }

	[TableColumn("entitlementId")]
	public uint EntitlementId { get; set; }

	[TableColumn("entitlementCount")]
	public uint EntitlementCount { get; set; }

	[TableColumn("entitlementScopeEnum")]
	public uint EntitlementScopeEnum { get; set; }

	[TableColumn("instantEventEnum")]
	public uint InstantEventEnum { get; set; }

	[TableColumn("accountCurrencyEnum")]
	public uint AccountCurrencyEnum { get; set; }

	[TableColumn("accountCurrencyAmount")]
	public ulong AccountCurrencyAmount { get; set; }

	[TableColumn("buttonIcon")]
	public string ButtonIcon { get; set; } = string.Empty;

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("accountItemCooldownGroupId")]
	public uint AccountItemCooldownGroupId { get; set; }

	[TableColumn("storeDisplayInfoId")]
	public uint StoreDisplayInfoId { get; set; }

	[TableColumn("storeIdentifierUpsell")]
	public string StoreIdentifierUpsell { get; set; } = string.Empty;

	[TableColumn("creature2DisplayGroupIdGacha")]
	public uint Creature2DisplayGroupIdGacha { get; set; }

	[TableColumn("entitlementIdPurchase")]
	public uint EntitlementIdPurchase { get; set; }

	[TableColumn("genericUnlockSetId")]
	public uint GenericUnlockSetId { get; set; }
}
