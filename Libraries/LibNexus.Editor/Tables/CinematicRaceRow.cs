using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CinematicRaceRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("cinematicId")]
	public uint CinematicId { get; set; }

	[TableColumn("raceId")]
	public uint RaceId { get; set; }

	[TableColumn("maleAssetPath")]
	public string MaleAssetPath { get; set; } = string.Empty;

	[TableColumn("femaleAssetPath")]
	public string FemaleAssetPath { get; set; } = string.Empty;
}
