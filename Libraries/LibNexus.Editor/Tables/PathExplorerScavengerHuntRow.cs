using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathExplorerScavengerHuntRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("creature2IdStart")]
	public uint Creature2IdStart { get; set; }

	[TableColumn("pathExplorerScavengerClueId00")]
	public uint PathExplorerScavengerClueId00 { get; set; }

	[TableColumn("pathExplorerScavengerClueId01")]
	public uint PathExplorerScavengerClueId01 { get; set; }

	[TableColumn("pathExplorerScavengerClueId02")]
	public uint PathExplorerScavengerClueId02 { get; set; }

	[TableColumn("pathExplorerScavengerClueId03")]
	public uint PathExplorerScavengerClueId03 { get; set; }

	[TableColumn("pathExplorerScavengerClueId04")]
	public uint PathExplorerScavengerClueId04 { get; set; }

	[TableColumn("pathExplorerScavengerClueId05")]
	public uint PathExplorerScavengerClueId05 { get; set; }

	[TableColumn("pathExplorerScavengerClueId06")]
	public uint PathExplorerScavengerClueId06 { get; set; }

	[TableColumn("localizedTextIdStart")]
	public uint LocalizedTextIdStart { get; set; }

	[TableColumn("spell4IdRelic")]
	public uint Spell4IdRelic { get; set; }

	[TableColumn("assetPathSprite")]
	public string AssetPathSprite { get; set; } = string.Empty;
}
