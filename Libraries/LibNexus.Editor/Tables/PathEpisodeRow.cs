using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathEpisodeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdSummary")]
	public uint LocalizedTextIdSummary { get; set; }

	[TableColumn("worldId")]
	public uint WorldId { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("pathTypeEnum")]
	public uint PathTypeEnum { get; set; }
}
