using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathSettlerImprovementRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("countResource00")]
	public uint CountResource00 { get; set; }

	[TableColumn("countResource01")]
	public uint CountResource01 { get; set; }

	[TableColumn("countResource02")]
	public uint CountResource02 { get; set; }

	[TableColumn("countRecontributionResource00")]
	public uint CountRecontributionResource00 { get; set; }

	[TableColumn("countRecontributionResource01")]
	public uint CountRecontributionResource01 { get; set; }

	[TableColumn("countRecontributionResource02")]
	public uint CountRecontributionResource02 { get; set; }

	[TableColumn("spell4IdDisplay")]
	public uint Spell4IdDisplay { get; set; }
}
