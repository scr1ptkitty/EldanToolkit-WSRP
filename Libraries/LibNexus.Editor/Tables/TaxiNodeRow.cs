using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class TaxiNodeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("taxiNodeTypeEnum")]
	public uint TaxiNodeTypeEnum { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("flightPathTypeEnum")]
	public uint FlightPathTypeEnum { get; set; }

	[TableColumn("taxiNodeFactionEnum")]
	public uint TaxiNodeFactionEnum { get; set; }

	[TableColumn("worldLocation2Id")]
	public uint WorldLocation2Id { get; set; }

	[TableColumn("contentTier")]
	public uint ContentTier { get; set; }

	[TableColumn("autoUnlockLevel")]
	public uint AutoUnlockLevel { get; set; }

	[TableColumn("recommendedMinLevel")]
	public uint RecommendedMinLevel { get; set; }

	[TableColumn("recommendedMaxLevel")]
	public uint RecommendedMaxLevel { get; set; }
}
