using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class AchievementTextRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }
}
