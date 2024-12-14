using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2DisplayGroupEntryRow
{
	[TableColumn("id")]
	public uint Id { get; set; }

	[TableColumn("creature2DisplayGroupId")]
	public uint Creature2DisplayGroupId { get; set; }

	[TableColumn("creature2DisplayInfoId")]
	public uint Creature2DisplayInfoId { get; set; }

	[TableColumn("weight")]
	public uint Weight { get; set; }
}
