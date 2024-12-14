using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSettlerImprovementGroupRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("pathSettlerHubId")]
	public uint PathSettlerHubId { get; set; }

	[TableColumn("pathSettlerImprovementGroupFlags")]
	public uint PathSettlerImprovementGroupFlags { get; set; }

	[TableColumn("creature2IdDepot")]
	public uint Creature2IdDepot { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("settlerAvenueTypeEnum")]
	public uint SettlerAvenueTypeEnum { get; set; }

	[TableColumn("contributionValue")]
	public uint ContributionValue { get; set; }

	[TableColumn("perTierBonusContributionValue")]
	public uint PerTierBonusContributionValue { get; set; }

	[TableColumn("durationPerBundleMs")]
	public uint DurationPerBundleMs { get; set; }

	[TableColumn("maxBundleCount")]
	public uint MaxBundleCount { get; set; }

	[TableColumn("pathSettlerImprovementGroupIdOutpostRequired")]
	public uint PathSettlerImprovementGroupIdOutpostRequired { get; set; }

	[TableColumn("pathSettlerImprovementIdTier00")]
	public uint PathSettlerImprovementIdTier00 { get; set; }

	[TableColumn("pathSettlerImprovementIdTier01")]
	public uint PathSettlerImprovementIdTier01 { get; set; }

	[TableColumn("pathSettlerImprovementIdTier02")]
	public uint PathSettlerImprovementIdTier02 { get; set; }

	[TableColumn("pathSettlerImprovementIdTier03")]
	public uint PathSettlerImprovementIdTier03 { get; set; }

	[TableColumn("worldLocation2IdDisplayPoint")]
	public uint WorldLocation2IdDisplayPoint { get; set; }
}
