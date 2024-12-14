using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WaterSurfaceEffectRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("emissionDelay")]
	public uint EmissionDelay { get; set; }

	[TableColumn("worldWaterWakeIdStillWater0")]
	public uint WorldWaterWakeIdStillWater0 { get; set; }

	[TableColumn("worldWaterWakeIdStillWater1")]
	public uint WorldWaterWakeIdStillWater1 { get; set; }

	[TableColumn("visualEffectIdParticle0")]
	public uint VisualEffectIdParticle0 { get; set; }

	[TableColumn("visualEffectIdParticle1")]
	public uint VisualEffectIdParticle1 { get; set; }

	[TableColumn("particleFlags0")]
	public uint ParticleFlags0 { get; set; }

	[TableColumn("particleFlags1")]
	public uint ParticleFlags1 { get; set; }
}
