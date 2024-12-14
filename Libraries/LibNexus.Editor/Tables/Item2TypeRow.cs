using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Item2TypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("itemSlotId")]
	public uint ItemSlotId { get; set; }

	[TableColumn("soundEventIdLoot")]
	public uint SoundEventIdLoot { get; set; }

	[TableColumn("soundEventIdEquip")]
	public uint SoundEventIdEquip { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("vendorMultiplier")]
	public float VendorMultiplier { get; set; }

	[TableColumn("turninMultiplier")]
	public float TurninMultiplier { get; set; }

	[TableColumn("Item2CategoryId")]
	public uint Item2CategoryId { get; set; }

	[TableColumn("referenceMuzzleX")]
	public float ReferenceMuzzleX { get; set; }

	[TableColumn("referenceMuzzleY")]
	public float ReferenceMuzzleY { get; set; }

	[TableColumn("referenceMuzzleZ")]
	public float ReferenceMuzzleZ { get; set; }
}
