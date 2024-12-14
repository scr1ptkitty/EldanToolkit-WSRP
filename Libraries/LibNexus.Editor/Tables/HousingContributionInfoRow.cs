using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingContributionInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("housingContributionTypeId")]
	public uint HousingContributionTypeId { get; set; }

	[TableColumn("contributionPointRequirement")]
	public uint ContributionPointRequirement { get; set; }

	[TableColumn("item2IdTier00")]
	public uint Item2IdTier00 { get; set; }

	[TableColumn("item2IdTier01")]
	public uint Item2IdTier01 { get; set; }

	[TableColumn("item2IdTier02")]
	public uint Item2IdTier02 { get; set; }

	[TableColumn("item2IdTier03")]
	public uint Item2IdTier03 { get; set; }

	[TableColumn("item2IdTier04")]
	public uint Item2IdTier04 { get; set; }

	[TableColumn("contributionPointValueTier00")]
	public uint ContributionPointValueTier00 { get; set; }

	[TableColumn("contributionPointValueTier01")]
	public uint ContributionPointValueTier01 { get; set; }

	[TableColumn("contributionPointValueTier02")]
	public uint ContributionPointValueTier02 { get; set; }

	[TableColumn("contributionPointValueTier03")]
	public uint ContributionPointValueTier03 { get; set; }

	[TableColumn("contributionPointValueTier04")]
	public uint ContributionPointValueTier04 { get; set; }
}
