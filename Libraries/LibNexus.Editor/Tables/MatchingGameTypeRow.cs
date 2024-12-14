using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MatchingGameTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("matchTypeEnum")]
	public uint MatchTypeEnum { get; set; }

	[TableColumn("matchingGameTypeEnumFlags")]
	public uint MatchingGameTypeEnumFlags { get; set; }

	[TableColumn("teamSize")]
	public uint TeamSize { get; set; }

	[TableColumn("minLevel")]
	public uint MinLevel { get; set; }

	[TableColumn("maxLevel")]
	public uint MaxLevel { get; set; }

	[TableColumn("preparationTimeMS")]
	public uint PreparationTimeMs { get; set; }

	[TableColumn("matchTimeMS")]
	public uint MatchTimeMs { get; set; }

	[TableColumn("matchingRulesEnum")]
	public uint MatchingRulesEnum { get; set; }

	[TableColumn("matchingRulesData00")]
	public uint MatchingRulesData00 { get; set; }

	[TableColumn("matchingRulesData01")]
	public uint MatchingRulesData01 { get; set; }

	[TableColumn("targetItemLevel")]
	public uint TargetItemLevel { get; set; }
}
