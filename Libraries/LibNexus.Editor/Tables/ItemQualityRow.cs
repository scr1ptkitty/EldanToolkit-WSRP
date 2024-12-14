using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemQualityRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("salvageCritChance")]
	public float SalvageCritChance { get; set; }

	[TableColumn("turninMultiplier")]
	public float TurninMultiplier { get; set; }

	[TableColumn("runeCostMultiplier")]
	public float RuneCostMultiplier { get; set; }

	[TableColumn("dyeCostMultiplier")]
	public float DyeCostMultiplier { get; set; }

	[TableColumn("visualEffectIdLoot")]
	public uint VisualEffectIdLoot { get; set; }

	[TableColumn("iconColorR")]
	public float IconColorR { get; set; }

	[TableColumn("iconColorG")]
	public float IconColorG { get; set; }

	[TableColumn("iconColorB")]
	public float IconColorB { get; set; }

	[TableColumn("defaultRunes")]
	public uint DefaultRunes { get; set; }

	[TableColumn("maxRunes")]
	public uint MaxRunes { get; set; }

	[TableColumn("assetPathDieModel")]
	public string AssetPathDieModel { get; set; } = string.Empty;

	[TableColumn("soundEventIdFortuneCardFanfare")]
	public uint SoundEventIdFortuneCardFanfare { get; set; }
}
