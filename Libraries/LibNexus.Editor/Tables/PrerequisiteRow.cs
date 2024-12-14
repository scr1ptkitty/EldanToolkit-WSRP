using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PrerequisiteRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("prerequisiteTypeId0")]
	public uint PrerequisiteTypeId0 { get; set; }

	[TableColumn("prerequisiteTypeId1")]
	public uint PrerequisiteTypeId1 { get; set; }

	[TableColumn("prerequisiteTypeId2")]
	public uint PrerequisiteTypeId2 { get; set; }

	[TableColumn("prerequisiteComparisonId0")]
	public uint PrerequisiteComparisonId0 { get; set; }

	[TableColumn("prerequisiteComparisonId1")]
	public uint PrerequisiteComparisonId1 { get; set; }

	[TableColumn("prerequisiteComparisonId2")]
	public uint PrerequisiteComparisonId2 { get; set; }

	[TableColumn("objectId0")]
	public uint ObjectId0 { get; set; }

	[TableColumn("objectId1")]
	public uint ObjectId1 { get; set; }

	[TableColumn("objectId2")]
	public uint ObjectId2 { get; set; }

	[TableColumn("value0")]
	public uint Value0 { get; set; }

	[TableColumn("value1")]
	public uint Value1 { get; set; }

	[TableColumn("value2")]
	public uint Value2 { get; set; }

	[TableColumn("localizedTextIdFailure")]
	public uint LocalizedTextIdFailure { get; set; }
}
