using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Item2FamilyRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("soundEventIdEquip")]
	public uint SoundEventIdEquip { get; set; }

	[TableColumn("vendorMultiplier")]
	public float VendorMultiplier { get; set; }

	[TableColumn("turninMultiplier")]
	public float TurninMultiplier { get; set; }
}
