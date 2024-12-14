using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemProficiencyRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("bitMask")]
	public uint BitMask { get; set; }

	[TableColumn("localizedTextIdString")]
	public uint LocalizedTextIdString { get; set; }
}
