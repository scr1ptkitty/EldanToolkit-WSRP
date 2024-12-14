using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSettlerHubRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("maxAvenueEconomy")]
	public uint MaxAvenueEconomy { get; set; }

	[TableColumn("maxAvenueSecurity")]
	public uint MaxAvenueSecurity { get; set; }

	[TableColumn("maxAvenueQualityOfLife")]
	public uint MaxAvenueQualityOfLife { get; set; }

	[TableColumn("localizedTextIdEconomy")]
	public uint LocalizedTextIdEconomy { get; set; }

	[TableColumn("localizedTextIdSecurity")]
	public uint LocalizedTextIdSecurity { get; set; }

	[TableColumn("localizedTextIdQualityOfLife")]
	public uint LocalizedTextIdQualityOfLife { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("missionCount")]
	public uint MissionCount { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("item2IdResource00")]
	public uint Item2IdResource00 { get; set; }

	[TableColumn("item2IdResource01")]
	public uint Item2IdResource01 { get; set; }

	[TableColumn("item2IdResource02")]
	public uint Item2IdResource02 { get; set; }

	[TableColumn("publicEventObjectiveIdResource00")]
	public uint PublicEventObjectiveIdResource00 { get; set; }

	[TableColumn("publicEventObjectiveIdResource01")]
	public uint PublicEventObjectiveIdResource01 { get; set; }

	[TableColumn("publicEventObjectiveIdResource02")]
	public uint PublicEventObjectiveIdResource02 { get; set; }

	[TableColumn("worldLocation2IdMapResource00Loc00")]
	public uint WorldLocation2IdMapResource00Loc00 { get; set; }

	[TableColumn("worldLocation2IdMapResource00Loc01")]
	public uint WorldLocation2IdMapResource00Loc01 { get; set; }

	[TableColumn("worldLocation2IdMapResource00Loc02")]
	public uint WorldLocation2IdMapResource00Loc02 { get; set; }

	[TableColumn("worldLocation2IdMapResource00Loc03")]
	public uint WorldLocation2IdMapResource00Loc03 { get; set; }

	[TableColumn("worldLocation2IdMapResource01Loc00")]
	public uint WorldLocation2IdMapResource01Loc00 { get; set; }

	[TableColumn("worldLocation2IdMapResource01Loc01")]
	public uint WorldLocation2IdMapResource01Loc01 { get; set; }

	[TableColumn("worldLocation2IdMapResource01Loc02")]
	public uint WorldLocation2IdMapResource01Loc02 { get; set; }

	[TableColumn("worldLocation2IdMapResource01Loc03")]
	public uint WorldLocation2IdMapResource01Loc03 { get; set; }

	[TableColumn("worldLocation2IdMapResource02Loc00")]
	public uint WorldLocation2IdMapResource02Loc00 { get; set; }

	[TableColumn("worldLocation2IdMapResource02Loc01")]
	public uint WorldLocation2IdMapResource02Loc01 { get; set; }

	[TableColumn("worldLocation2IdMapResource02Loc02")]
	public uint WorldLocation2IdMapResource02Loc02 { get; set; }

	[TableColumn("worldLocation2IdMapResource02Loc03")]
	public uint WorldLocation2IdMapResource02Loc03 { get; set; }

	[TableColumn("localizedTextIdRewardNotify")]
	public uint LocalizedTextIdRewardNotify { get; set; }
}
