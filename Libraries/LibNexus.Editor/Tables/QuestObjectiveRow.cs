using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class QuestObjectiveRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("type")]
	public uint Type { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("data")]
	public uint Data { get; set; }

	[TableColumn("count")]
	public uint Count { get; set; }

	[TableColumn("localizedTextIdFull")]
	public uint LocalizedTextIdFull { get; set; }

	[TableColumn("worldLocationsIdIndicator00")]
	public uint WorldLocationsIdIndicator00 { get; set; }

	[TableColumn("worldLocationsIdIndicator01")]
	public uint WorldLocationsIdIndicator01 { get; set; }

	[TableColumn("worldLocationsIdIndicator02")]
	public uint WorldLocationsIdIndicator02 { get; set; }

	[TableColumn("worldLocationsIdIndicator03")]
	public uint WorldLocationsIdIndicator03 { get; set; }

	[TableColumn("maxTimeAllowedMS")]
	public uint MaxTimeAllowedMs { get; set; }

	[TableColumn("localizedTextIdShort")]
	public uint LocalizedTextIdShort { get; set; }

	[TableColumn("targetGroupIdRewardPane")]
	public uint TargetGroupIdRewardPane { get; set; }

	[TableColumn("questDirectionId")]
	public uint QuestDirectionId { get; set; }
}
