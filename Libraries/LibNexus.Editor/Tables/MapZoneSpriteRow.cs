using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class MapZoneSpriteRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("spriteName")]
	public string SpriteName { get; set; } = string.Empty;
}
