using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingNeighborhoodInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("baseCost")]
	public uint BaseCost { get; set; }

	[TableColumn("maxPopulation")]
	public uint MaxPopulation { get; set; }

	[TableColumn("populationThreshold")]
	public uint PopulationThreshold { get; set; }

	[TableColumn("housingFactionEnum")]
	public uint HousingFactionEnum { get; set; }

	[TableColumn("housingFeatureTypeEnum")]
	public uint HousingFeatureTypeEnum { get; set; }

	[TableColumn("housingPlaystyleTypeEnum")]
	public uint HousingPlaystyleTypeEnum { get; set; }

	[TableColumn("housingMapInfoIdPrimary")]
	public uint HousingMapInfoIdPrimary { get; set; }

	[TableColumn("housingMapInfoIdSecondary")]
	public uint HousingMapInfoIdSecondary { get; set; }
}
