using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldWaterTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("worldWaterFogId")]
	public uint WorldWaterFogId { get; set; }

	[TableColumn("SurfaceType")]
	public uint SurfaceType { get; set; }

	[TableColumn("particleFile")]
	public string ParticleFile { get; set; } = string.Empty;

	[TableColumn("soundDirectionalAmbienceId")]
	public uint SoundDirectionalAmbienceId { get; set; }
}
