using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventVoteRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("localizedTextIdOption00")]
	public uint LocalizedTextIdOption00 { get; set; }

	[TableColumn("localizedTextIdOption01")]
	public uint LocalizedTextIdOption01 { get; set; }

	[TableColumn("localizedTextIdOption02")]
	public uint LocalizedTextIdOption02 { get; set; }

	[TableColumn("localizedTextIdOption03")]
	public uint LocalizedTextIdOption03 { get; set; }

	[TableColumn("localizedTextIdOption04")]
	public uint LocalizedTextIdOption04 { get; set; }

	[TableColumn("localizedTextIdLabel00")]
	public uint LocalizedTextIdLabel00 { get; set; }

	[TableColumn("localizedTextIdLabel01")]
	public uint LocalizedTextIdLabel01 { get; set; }

	[TableColumn("localizedTextIdLabel02")]
	public uint LocalizedTextIdLabel02 { get; set; }

	[TableColumn("localizedTextIdLabel03")]
	public uint LocalizedTextIdLabel03 { get; set; }

	[TableColumn("localizedTextIdLabel04")]
	public uint LocalizedTextIdLabel04 { get; set; }

	[TableColumn("durationMS")]
	public uint DurationMs { get; set; }

	[TableColumn("assetPathSprite")]
	public string AssetPathSprite { get; set; } = string.Empty;
}
