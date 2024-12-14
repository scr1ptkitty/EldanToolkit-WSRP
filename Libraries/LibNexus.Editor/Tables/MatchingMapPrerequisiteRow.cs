using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MatchingMapPrerequisiteRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("matchingGameMapId")]
	public uint MatchingGameMapId { get; set; }

	[TableColumn("matchingEligibilityFlagEnum")]
	public uint MatchingEligibilityFlagEnum { get; set; }
}
