using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LootSpellRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("lootSpellTypeEnum")]
	public uint LootSpellTypeEnum { get; set; }

	[TableColumn("lootSpellPickupEnumFlags")]
	public uint LootSpellPickupEnumFlags { get; set; }

	[TableColumn("creature2Id")]
	public uint Creature2Id { get; set; }

	[TableColumn("buttonIcon")]
	public string ButtonIcon { get; set; } = string.Empty;

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("visualEffectId")]
	public uint VisualEffectId { get; set; }

	[TableColumn("data")]
	public uint Data { get; set; }

	[TableColumn("dataValue")]
	public uint DataValue { get; set; }
}
