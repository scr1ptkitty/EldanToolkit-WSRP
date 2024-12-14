using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WorldWaterEnvironmentRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("LandMapPath")]
	public string LandMapPath { get; set; } = string.Empty;
}
