using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Creature2ActionTextRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdOnEnterCombat00")]
	public uint LocalizedTextIdOnEnterCombat00 { get; set; }

	[TableColumn("localizedTextIdOnEnterCombat01")]
	public uint LocalizedTextIdOnEnterCombat01 { get; set; }

	[TableColumn("localizedTextIdOnEnterCombat02")]
	public uint LocalizedTextIdOnEnterCombat02 { get; set; }

	[TableColumn("localizedTextIdOnEnterCombat03")]
	public uint LocalizedTextIdOnEnterCombat03 { get; set; }

	[TableColumn("chanceToSayOnEnterCombat")]
	public float ChanceToSayOnEnterCombat { get; set; }

	[TableColumn("localizedTextIdOnDeath00")]
	public uint LocalizedTextIdOnDeath00 { get; set; }

	[TableColumn("localizedTextIdOnDeath01")]
	public uint LocalizedTextIdOnDeath01 { get; set; }

	[TableColumn("localizedTextIdOnDeath02")]
	public uint LocalizedTextIdOnDeath02 { get; set; }

	[TableColumn("localizedTextIdOnDeath03")]
	public uint LocalizedTextIdOnDeath03 { get; set; }

	[TableColumn("chanceToSayOnDeath")]
	public float ChanceToSayOnDeath { get; set; }

	[TableColumn("localizedTextIdOnKill00")]
	public uint LocalizedTextIdOnKill00 { get; set; }

	[TableColumn("localizedTextIdOnKill01")]
	public uint LocalizedTextIdOnKill01 { get; set; }

	[TableColumn("localizedTextIdOnKill02")]
	public uint LocalizedTextIdOnKill02 { get; set; }

	[TableColumn("localizedTextIdOnKill03")]
	public uint LocalizedTextIdOnKill03 { get; set; }

	[TableColumn("chanceToSayOnKill")]
	public float ChanceToSayOnKill { get; set; }
}
