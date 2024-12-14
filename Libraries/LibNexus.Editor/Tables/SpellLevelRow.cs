using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SpellLevelRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("classId")]
	public uint ClassId { get; set; }

	[TableColumn("characterLevel")]
	public uint CharacterLevel { get; set; }

	[TableColumn("prerequisiteId")]
	public uint PrerequisiteId { get; set; }

	[TableColumn("spell4Id")]
	public uint Spell4Id { get; set; }

	[TableColumn("costMultiplier")]
	public float CostMultiplier { get; set; }
}
