using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingBuildRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("assetPath")]
	public string AssetPath { get; set; } = string.Empty;

	[TableColumn("constructionEffectsId")]
	public uint ConstructionEffectsId { get; set; }

	[TableColumn("buildPreDelayTimeMS")]
	public float BuildPreDelayTimeMs { get; set; }

	[TableColumn("buildPostDelayTimeMS")]
	public float BuildPostDelayTimeMs { get; set; }

	[TableColumn("buildTime00")]
	public float BuildTime00 { get; set; }

	[TableColumn("buildTime01")]
	public float BuildTime01 { get; set; }

	[TableColumn("buildTime02")]
	public float BuildTime02 { get; set; }

	[TableColumn("buildTime03")]
	public float BuildTime03 { get; set; }

	[TableColumn("buildTime04")]
	public float BuildTime04 { get; set; }

	[TableColumn("buildTime05")]
	public float BuildTime05 { get; set; }

	[TableColumn("buildTime06")]
	public float BuildTime06 { get; set; }

	[TableColumn("buildTime07")]
	public float BuildTime07 { get; set; }

	[TableColumn("modelSequenceId00")]
	public uint ModelSequenceId00 { get; set; }

	[TableColumn("modelSequenceId01")]
	public uint ModelSequenceId01 { get; set; }

	[TableColumn("modelSequenceId02")]
	public uint ModelSequenceId02 { get; set; }

	[TableColumn("modelSequenceId03")]
	public uint ModelSequenceId03 { get; set; }

	[TableColumn("modelSequenceId04")]
	public uint ModelSequenceId04 { get; set; }

	[TableColumn("modelSequenceId05")]
	public uint ModelSequenceId05 { get; set; }

	[TableColumn("modelSequenceId06")]
	public uint ModelSequenceId06 { get; set; }

	[TableColumn("modelSequenceId07")]
	public uint ModelSequenceId07 { get; set; }
}
