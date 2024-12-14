using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2OutfitInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("itemDisplayId00")]
	public uint ItemDisplayId00 { get; set; }

	[TableColumn("itemDisplayId01")]
	public uint ItemDisplayId01 { get; set; }

	[TableColumn("itemDisplayId02")]
	public uint ItemDisplayId02 { get; set; }

	[TableColumn("itemDisplayId03")]
	public uint ItemDisplayId03 { get; set; }

	[TableColumn("itemDisplayId04")]
	public uint ItemDisplayId04 { get; set; }

	[TableColumn("itemDisplayId05")]
	public uint ItemDisplayId05 { get; set; }

	[TableColumn("itemColorSetId00")]
	public uint ItemColorSetId00 { get; set; }

	[TableColumn("itemColorSetId01")]
	public uint ItemColorSetId01 { get; set; }

	[TableColumn("itemColorSetId02")]
	public uint ItemColorSetId02 { get; set; }

	[TableColumn("itemColorSetId03")]
	public uint ItemColorSetId03 { get; set; }

	[TableColumn("itemColorSetId04")]
	public uint ItemColorSetId04 { get; set; }

	[TableColumn("itemColorSetId05")]
	public uint ItemColorSetId05 { get; set; }
}
