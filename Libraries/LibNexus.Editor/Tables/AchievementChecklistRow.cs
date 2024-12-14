using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AchievementChecklistRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("achievementId")]
	public uint AchievementId { get; set; }

	[TableColumn("bit")]
	public uint Bit { get; set; }

	[TableColumn("objectId")]
	public uint ObjectId { get; set; }

	[TableColumn("objectIdAlt")]
	public uint ObjectIdAlt { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("prerequisiteIdAlt")]
	public uint PrerequisiteIdAlt { get; set; }
}
