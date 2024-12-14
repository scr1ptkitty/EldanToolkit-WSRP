using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("mapContinentId")]
	public uint MapContinentId { get; set; }

	[TableColumn("folder")]
	public string Folder { get; set; } = string.Empty;

	[TableColumn("hexMinX")]
	public uint HexMinX { get; set; }

	[TableColumn("hexMinY")]
	public uint HexMinY { get; set; }

	[TableColumn("hexLimX")]
	public uint HexLimX { get; set; }

	[TableColumn("hexLimY")]
	public uint HexLimY { get; set; }

	[TableColumn("version")]
	public uint Version { get; set; }

	[TableColumn("mapZoneIdParent")]
	public uint MapZoneIdParent { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("prerequisiteIdVisibility")]
	public uint PrerequisiteIdVisibility { get; set; }

	[TableColumn("rewardTrackId")]
	public uint RewardTrackId { get; set; }
}
