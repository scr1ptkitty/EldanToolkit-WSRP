using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("assetPath")]
	public string AssetPath { get; set; } = string.Empty;

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("type")]
	public uint Type { get; set; }

	[TableColumn("screenPath")]
	public string ScreenPath { get; set; } = string.Empty;

	[TableColumn("screenModelPath")]
	public string ScreenModelPath { get; set; } = string.Empty;

	[TableColumn("chunkBounds00")]
	public uint ChunkBounds00 { get; set; }

	[TableColumn("chunkBounds01")]
	public uint ChunkBounds01 { get; set; }

	[TableColumn("chunkBounds02")]
	public uint ChunkBounds02 { get; set; }

	[TableColumn("chunkBounds03")]
	public uint ChunkBounds03 { get; set; }

	[TableColumn("plugAverageHeight")]
	public uint PlugAverageHeight { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("minItemLevel")]
	public uint MinItemLevel { get; set; }

	[TableColumn("maxItemLevel")]
	public uint MaxItemLevel { get; set; }

	[TableColumn("primeLevelOffset")]
	public uint PrimeLevelOffset { get; set; }

	[TableColumn("primeLevelMax")]
	public uint PrimeLevelMax { get; set; }

	[TableColumn("veteranTierScalingType")]
	public uint VeteranTierScalingType { get; set; }

	[TableColumn("heroismMenaceLevel")]
	public uint HeroismMenaceLevel { get; set; }

	[TableColumn("rewardRotationContentId")]
	public uint RewardRotationContentId { get; set; }
}
