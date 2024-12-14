using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingPlugItemRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("housingPlotTypeId")]
	public uint HousingPlotTypeId { get; set; }

	[TableColumn("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[TableColumn("worldIdPlug00")]
	public uint WorldIdPlug00 { get; set; }

	[TableColumn("worldIdPlug01")]
	public uint WorldIdPlug01 { get; set; }

	[TableColumn("worldIdPlug02")]
	public uint WorldIdPlug02 { get; set; }

	[TableColumn("worldIdPlug03")]
	public uint WorldIdPlug03 { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("housingResourceIdProvided00")]
	public uint HousingResourceIdProvided00 { get; set; }

	[TableColumn("housingResourceIdProvided01")]
	public uint HousingResourceIdProvided01 { get; set; }

	[TableColumn("housingResourceIdProvided02")]
	public uint HousingResourceIdProvided02 { get; set; }

	[TableColumn("housingResourceIdProvided03")]
	public uint HousingResourceIdProvided03 { get; set; }

	[TableColumn("housingResourceIdProvided04")]
	public uint HousingResourceIdProvided04 { get; set; }

	[TableColumn("housingResourceIdPrerequisite00")]
	public uint HousingResourceIdPrerequisite00 { get; set; }

	[TableColumn("housingResourceIdPrerequisite01")]
	public uint HousingResourceIdPrerequisite01 { get; set; }

	[TableColumn("housingResourceIdPrerequisite02")]
	public uint HousingResourceIdPrerequisite02 { get; set; }

	[TableColumn("housingFeatureTypeFlags")]
	public uint HousingFeatureTypeFlags { get; set; }

	[TableColumn("housingContributionInfoId00")]
	public uint HousingContributionInfoId00 { get; set; }

	[TableColumn("housingContributionInfoId01")]
	public uint HousingContributionInfoId01 { get; set; }

	[TableColumn("housingContributionInfoId02")]
	public uint HousingContributionInfoId02 { get; set; }

	[TableColumn("housingContributionInfoId03")]
	public uint HousingContributionInfoId03 { get; set; }

	[TableColumn("housingContributionInfoId04")]
	public uint HousingContributionInfoId04 { get; set; }

	[TableColumn("housingPlugItemIdNextUpgrade")]
	public uint HousingPlugItemIdNextUpgrade { get; set; }

	[TableColumn("localizedTextIdPrereqTooltip00")]
	public uint LocalizedTextIdPrereqTooltip00 { get; set; }

	[TableColumn("localizedTextIdPrereqTooltip01")]
	public uint LocalizedTextIdPrereqTooltip01 { get; set; }

	[TableColumn("localizedTextIdPrereqTooltip02")]
	public uint LocalizedTextIdPrereqTooltip02 { get; set; }

	[TableColumn("prerequisiteId00")]
	public uint PrerequisiteId00 { get; set; }

	[TableColumn("prerequisiteId01")]
	public uint PrerequisiteId01 { get; set; }

	[TableColumn("prerequisiteId02")]
	public uint PrerequisiteId02 { get; set; }

	[TableColumn("prerequisiteIdUnlock")]
	public uint PrerequisiteIdUnlock { get; set; }

	[TableColumn("housingBuildId")]
	public uint HousingBuildId { get; set; }

	[TableColumn("housingUpkeepTypeEnum")]
	public uint HousingUpkeepTypeEnum { get; set; }

	[TableColumn("upkeepCharges")]
	public uint UpkeepCharges { get; set; }

	[TableColumn("upkeepTime")]
	public float UpkeepTime { get; set; }

	[TableColumn("housingContributionInfoIdUpkeepCost00")]
	public uint HousingContributionInfoIdUpkeepCost00 { get; set; }

	[TableColumn("housingContributionInfoIdUpkeepCost01")]
	public uint HousingContributionInfoIdUpkeepCost01 { get; set; }

	[TableColumn("housingContributionInfoIdUpkeepCost02")]
	public uint HousingContributionInfoIdUpkeepCost02 { get; set; }

	[TableColumn("housingContributionInfoIdUpkeepCost03")]
	public uint HousingContributionInfoIdUpkeepCost03 { get; set; }

	[TableColumn("housingContributionInfoIdUpkeepCost04")]
	public uint HousingContributionInfoIdUpkeepCost04 { get; set; }

	[TableColumn("gameFormulaIdHousingBuildBonus")]
	public uint GameFormulaIdHousingBuildBonus { get; set; }

	[TableColumn("screenshotSprite00")]
	public string ScreenshotSprite00 { get; set; } = string.Empty;

	[TableColumn("screenshotSprite01")]
	public string ScreenshotSprite01 { get; set; } = string.Empty;

	[TableColumn("screenshotSprite02")]
	public string ScreenshotSprite02 { get; set; } = string.Empty;

	[TableColumn("screenshotSprite03")]
	public string ScreenshotSprite03 { get; set; } = string.Empty;

	[TableColumn("screenshotSprite04")]
	public string ScreenshotSprite04 { get; set; } = string.Empty;

	[TableColumn("housingPlugTypeEnum")]
	public uint HousingPlugTypeEnum { get; set; }

	[TableColumn("accountItemIdUpsell")]
	public uint AccountItemIdUpsell { get; set; }
}
