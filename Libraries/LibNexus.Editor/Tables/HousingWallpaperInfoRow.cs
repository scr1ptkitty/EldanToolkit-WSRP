using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingWallpaperInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("cost")]
	public uint Cost { get; set; }

	[TableColumn("costCurrencyTypeId")]
	public uint CostCurrencyTypeId { get; set; }

	[TableColumn("replaceableMaterialInfoId")]
	public uint ReplaceableMaterialInfoId { get; set; }

	[TableColumn("worldSkyId")]
	public uint WorldSkyId { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("prerequisiteIdUnlock")]
	public uint PrerequisiteIdUnlock { get; set; }

	[TableColumn("prerequisiteIdUse")]
	public uint PrerequisiteIdUse { get; set; }

	[TableColumn("unlockIndex")]
	public uint UnlockIndex { get; set; }

	[TableColumn("soundZoneKitId")]
	public uint SoundZoneKitId { get; set; }

	[TableColumn("worldLayerId00")]
	public uint WorldLayerId00 { get; set; }

	[TableColumn("worldLayerId01")]
	public uint WorldLayerId01 { get; set; }

	[TableColumn("worldLayerId02")]
	public uint WorldLayerId02 { get; set; }

	[TableColumn("worldLayerId03")]
	public uint WorldLayerId03 { get; set; }

	[TableColumn("accountItemIdUpsell")]
	public uint AccountItemIdUpsell { get; set; }
}
