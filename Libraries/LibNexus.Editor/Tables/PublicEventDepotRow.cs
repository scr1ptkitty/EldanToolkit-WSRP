using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventDepotRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("creature2Id")]
	public uint Creature2Id { get; set; }

	[TableColumn("item2Id")]
	public uint Item2Id { get; set; }
}
