using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterCreationArmorSetRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("creationGearSetEnum")]
	public uint CreationGearSetEnum { get; set; }

	[TableColumn("classId")]
	public uint ClassId { get; set; }

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

	[TableColumn("itemDisplayId06")]
	public uint ItemDisplayId06 { get; set; }

	[TableColumn("itemDisplayId07")]
	public uint ItemDisplayId07 { get; set; }

	[TableColumn("itemDisplayId08")]
	public uint ItemDisplayId08 { get; set; }

	[TableColumn("itemDisplayId09")]
	public uint ItemDisplayId09 { get; set; }

	[TableColumn("itemDisplayId10")]
	public uint ItemDisplayId10 { get; set; }

	[TableColumn("itemDisplayId11")]
	public uint ItemDisplayId11 { get; set; }
}
