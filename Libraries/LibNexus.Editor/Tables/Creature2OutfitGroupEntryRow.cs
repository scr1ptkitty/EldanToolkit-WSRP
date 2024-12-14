using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2OutfitGroupEntryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("creature2OutfitGroupId")]
	public uint Creature2OutfitGroupId { get; set; }

	[TableColumn("creature2OutfitInfoId")]
	public uint Creature2OutfitInfoId { get; set; }

	[TableColumn("weight")]
	public uint Weight { get; set; }
}
