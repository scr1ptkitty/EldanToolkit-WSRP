using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSoldierEventWaveRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("pathSoldierEventId")]
	public uint PathSoldierEventId { get; set; }

	[TableColumn("waveIndex")]
	public uint WaveIndex { get; set; }

	[TableColumn("soundZoneKitId")]
	public uint SoundZoneKitId { get; set; }
}
