using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4RunnerRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("spriteName")]
	public string SpriteName { get; set; } = string.Empty;

	[TableColumn("redTint")]
	public float RedTint { get; set; }

	[TableColumn("greenTint")]
	public float GreenTint { get; set; }

	[TableColumn("blueTint")]
	public float BlueTint { get; set; }

	[TableColumn("alphaTint")]
	public float AlphaTint { get; set; }

	[TableColumn("rate")]
	public float Rate { get; set; }
}
