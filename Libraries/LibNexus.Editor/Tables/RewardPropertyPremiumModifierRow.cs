using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardPropertyPremiumModifierRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("premiumSystemEnum")]
	public uint PremiumSystemEnum { get; set; }

	[TableColumn("tier")]
	public uint Tier { get; set; }

	[TableColumn("rewardPropertyId")]
	public uint RewardPropertyId { get; set; }

	[TableColumn("rewardPropertyData")]
	public uint RewardPropertyData { get; set; }

	[TableColumn("modifierValueInt")]
	public uint ModifierValueInt { get; set; }

	[TableColumn("modifierValueFloat")]
	public float ModifierValueFloat { get; set; }

	[TableColumn("entitlementIdModifierCount")]
	public uint EntitlementIdModifierCount { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
