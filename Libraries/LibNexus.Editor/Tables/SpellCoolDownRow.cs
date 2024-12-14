using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SpellCoolDownRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("cooldownTime")]
	public uint CooldownTime { get; set; }
}
