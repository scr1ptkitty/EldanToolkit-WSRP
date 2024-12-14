using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PathScientistCreatureInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("scientistCreatureFlags")]
	public uint ScientistCreatureFlags { get; set; }

	[TableColumn("displayIcon")]
	public string DisplayIcon { get; set; } = string.Empty;

	[TableColumn("prerequisiteIdScan")]
	public uint PrerequisiteIdScan { get; set; }

	[TableColumn("prerequisiteIdRawScan")]
	public uint PrerequisiteIdRawScan { get; set; }

	[TableColumn("prerequisiteIdScanCreature")]
	public uint PrerequisiteIdScanCreature { get; set; }

	[TableColumn("prerequisiteIdRawScanCreature")]
	public uint PrerequisiteIdRawScanCreature { get; set; }

	[TableColumn("spell4IdBuff00")]
	public uint Spell4IdBuff00 { get; set; }

	[TableColumn("spell4IdBuff01")]
	public uint Spell4IdBuff01 { get; set; }

	[TableColumn("spell4IdBuff02")]
	public uint Spell4IdBuff02 { get; set; }

	[TableColumn("spell4IdBuff03")]
	public uint Spell4IdBuff03 { get; set; }

	[TableColumn("checklistCount")]
	public uint ChecklistCount { get; set; }

	[TableColumn("scientistCreatureTypeEnum")]
	public uint ScientistCreatureTypeEnum { get; set; }

	[TableColumn("lootId")]
	public uint LootId { get; set; }
}
