using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PetFlairRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("unlockBitIndex00")]
	public uint UnlockBitIndex00 { get; set; }

	[TableColumn("unlockBitIndex01")]
	public uint UnlockBitIndex01 { get; set; }

	[TableColumn("type")]
	public uint Type { get; set; }

	[TableColumn("spell4Id")]
	public uint Spell4Id { get; set; }

	[TableColumn("localizedTextIdTooltip")]
	public uint LocalizedTextIdTooltip { get; set; }

	[TableColumn("itemDisplayId00")]
	public uint ItemDisplayId00 { get; set; }

	[TableColumn("itemDisplayId01")]
	public uint ItemDisplayId01 { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }
}
