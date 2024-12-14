using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MatchingRandomRewardRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("matchTypeEnum")]
	public uint MatchTypeEnum { get; set; }

	[TableColumn("item2Id")]
	public uint Item2Id { get; set; }

	[TableColumn("itemCount")]
	public uint ItemCount { get; set; }

	[TableColumn("currencyTypeId")]
	public uint CurrencyTypeId { get; set; }

	[TableColumn("currencyValue")]
	public uint CurrencyValue { get; set; }

	[TableColumn("xpEarned")]
	public uint XpEarned { get; set; }

	[TableColumn("item2IdLevelScale")]
	public uint Item2IdLevelScale { get; set; }

	[TableColumn("itemCountLevelScale")]
	public uint ItemCountLevelScale { get; set; }

	[TableColumn("currencyTypeIdLevelScale")]
	public uint CurrencyTypeIdLevelScale { get; set; }

	[TableColumn("currencyValueLevelScale")]
	public uint CurrencyValueLevelScale { get; set; }

	[TableColumn("xpEarnedLevelScale")]
	public uint XpEarnedLevelScale { get; set; }

	[TableColumn("worldDifficultyEnum")]
	public uint WorldDifficultyEnum { get; set; }
}
