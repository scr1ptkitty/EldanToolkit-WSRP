using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathScientistExperimentationRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("numAttempts")]
	public uint NumAttempts { get; set; }
}
