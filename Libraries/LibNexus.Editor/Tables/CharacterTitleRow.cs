using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CharacterTitleRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("characterTitleCategoryId")]
	public uint CharacterTitleCategoryId { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdTitle")]
	public uint LocalizedTextIdTitle { get; set; }

	[TableColumn("spell4IdActivate")]
	public uint Spell4IdActivate { get; set; }

	[TableColumn("lifeTimeSeconds")]
	public uint LifeTimeSeconds { get; set; }

	[TableColumn("playerTitleFlagsEnum")]
	public uint PlayerTitleFlagsEnum { get; set; }

	[TableColumn("scheduleId")]
	public uint ScheduleId { get; set; }
}
