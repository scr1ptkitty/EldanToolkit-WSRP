using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LevelDifferentialAttributeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdDescription")]
	public uint LocalizedTextIdDescription { get; set; }

	[TableColumn("levelDifferentialValue")]
	public uint LevelDifferentialValue { get; set; }

	[TableColumn("questXpMultiplier")]
	public float QuestXpMultiplier { get; set; }
}
