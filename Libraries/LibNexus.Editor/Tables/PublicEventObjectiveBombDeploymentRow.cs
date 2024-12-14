using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventObjectiveBombDeploymentRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("creature2IdBomb")]
	public uint Creature2IdBomb { get; set; }

	[TableColumn("spell4IdCarrying")]
	public uint Spell4IdCarrying { get; set; }
}
