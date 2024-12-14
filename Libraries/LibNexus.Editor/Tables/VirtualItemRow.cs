using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class VirtualItemRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("buttonIcon")]
	public string ButtonIcon { get; set; } = string.Empty;

	[TableColumn("item2TypeId")]
	public uint Item2TypeId { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdFlavor")]
	public uint LocalizedTextIdFlavor { get; set; }

	[TableColumn("itemQualityId")]
	public uint ItemQualityId { get; set; }
}
