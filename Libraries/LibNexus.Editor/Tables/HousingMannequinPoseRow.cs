using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingMannequinPoseRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("modelSequenceId")]
	public uint ModelSequenceId { get; set; }
}
