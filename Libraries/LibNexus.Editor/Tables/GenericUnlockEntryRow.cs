using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GenericUnlockEntryRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("spriteIcon")]
	public string SpriteIcon { get; set; } = string.Empty;

	[TableColumn("spritePreview")]
	public string SpritePreview { get; set; } = string.Empty;

	[TableColumn("genericUnlockTypeEnum")]
	public uint GenericUnlockTypeEnum { get; set; }

	[TableColumn("unlockObject")]
	public uint UnlockObject { get; set; }
}
