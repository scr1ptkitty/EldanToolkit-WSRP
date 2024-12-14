using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AchievementSubGroupRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("tier")]
	public uint Tier { get; set; }
}
