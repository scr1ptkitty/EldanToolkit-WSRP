using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LootPinataInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("item2Id")]
	public uint Item2Id { get; set; }

	[TableColumn("item2TypeId")]
	public uint Item2TypeId { get; set; }

	[TableColumn("item2CategoryId")]
	public uint Item2CategoryId { get; set; }

	[TableColumn("item2FamilyId")]
	public uint Item2FamilyId { get; set; }

	[TableColumn("virtualItemId")]
	public uint VirtualItemId { get; set; }

	[TableColumn("accountCurrencyTypeId")]
	public uint AccountCurrencyTypeId { get; set; }

	[TableColumn("creature2IdChest")]
	public uint Creature2IdChest { get; set; }

	[TableColumn("mass")]
	public float Mass { get; set; }

	[TableColumn("soundEventId")]
	public uint SoundEventId { get; set; }
}
