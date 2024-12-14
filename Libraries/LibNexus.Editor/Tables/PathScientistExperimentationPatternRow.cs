using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathScientistExperimentationPatternRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("pathMissionId")]
	public uint PathMissionId { get; set; }

	[TableColumn("pathScientistExperimentationId")]
	public uint PathScientistExperimentationId { get; set; }

	[TableColumn("iconAssetPath")]
	public string IconAssetPath { get; set; } = string.Empty;
}
