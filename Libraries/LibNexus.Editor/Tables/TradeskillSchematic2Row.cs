using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TradeskillSchematic2Row
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("tradeSkillId")]
	public uint TradeSkillId { get; set; }

	[TableColumn("item2IdOutput")]
	public uint Item2IdOutput { get; set; }

	[TableColumn("item2IdOutputFail")]
	public uint Item2IdOutputFail { get; set; }

	[TableColumn("outputCount")]
	public uint OutputCount { get; set; }

	[TableColumn("lootId")]
	public uint LootId { get; set; }

	[TableColumn("tier")]
	public uint Tier { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("item2IdMaterial00")]
	public uint Item2IdMaterial00 { get; set; }

	[TableColumn("item2IdMaterial01")]
	public uint Item2IdMaterial01 { get; set; }

	[TableColumn("item2IdMaterial02")]
	public uint Item2IdMaterial02 { get; set; }

	[TableColumn("item2IdMaterial03")]
	public uint Item2IdMaterial03 { get; set; }

	[TableColumn("item2IdMaterial04")]
	public uint Item2IdMaterial04 { get; set; }

	[TableColumn("materialCost00")]
	public uint MaterialCost00 { get; set; }

	[TableColumn("materialCost01")]
	public uint MaterialCost01 { get; set; }

	[TableColumn("materialCost02")]
	public uint MaterialCost02 { get; set; }

	[TableColumn("materialCost03")]
	public uint MaterialCost03 { get; set; }

	[TableColumn("materialCost04")]
	public uint MaterialCost04 { get; set; }

	[TableColumn("tradeskillSchematic2IdParent")]
	public uint TradeskillSchematic2IdParent { get; set; }

	[TableColumn("vectorX")]
	public float VectorX { get; set; }

	[TableColumn("vectorY")]
	public float VectorY { get; set; }

	[TableColumn("radius")]
	public float Radius { get; set; }

	[TableColumn("critRadius")]
	public float CritRadius { get; set; }

	[TableColumn("item2IdOutputCrit")]
	public uint Item2IdOutputCrit { get; set; }

	[TableColumn("outputCountCritBonus")]
	public uint OutputCountCritBonus { get; set; }

	[TableColumn("priority")]
	public uint Priority { get; set; }

	[TableColumn("maxAdditives")]
	public uint MaxAdditives { get; set; }

	[TableColumn("discoverableQuadrant")]
	public uint DiscoverableQuadrant { get; set; }

	[TableColumn("discoverableRadius")]
	public float DiscoverableRadius { get; set; }

	[TableColumn("discoverableAngle")]
	public float DiscoverableAngle { get; set; }

	[TableColumn("tradeskillCatalystOrderingId")]
	public uint TradeskillCatalystOrderingId { get; set; }
}
