using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathRewardRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("pathRewardTypeEnum")]
	public uint PathRewardTypeEnum { get; set; }

	[TableColumn("objectId")]
	public uint ObjectId { get; set; }

	[TableColumn("spell4Id")]
	public uint Spell4Id { get; set; }

	[TableColumn("item2Id")]
	public uint Item2Id { get; set; }

	[TableColumn("quest2Id")]
	public uint Quest2Id { get; set; }

	[TableColumn("characterTitleId")]
	public uint CharacterTitleId { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("count")]
	public uint Count { get; set; }

	[TableColumn("pathRewardFlags")]
	public uint PathRewardFlags { get; set; }

	[TableColumn("pathScientistScanBotProfileId")]
	public uint PathScientistScanBotProfileId { get; set; }
}
