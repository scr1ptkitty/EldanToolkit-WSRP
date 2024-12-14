using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LevelUpUnlockRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("levelUpUnlockSystemEnum")]
	public uint LevelUpUnlockSystemEnum { get; set; }

	[TableColumn("level")]
	public uint Level { get; set; }

	[TableColumn("levelUpUnlockTypeId")]
	public uint LevelUpUnlockTypeId { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("displayIcon")]
	public string DisplayIcon { get; set; } = string.Empty;

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("levelUpUnlockValue")]
	public uint LevelUpUnlockValue { get; set; }
}
