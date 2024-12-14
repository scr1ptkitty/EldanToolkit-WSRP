using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class HousingContributionTypeRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("enumName")]
	public string EnumName { get; set; } = string.Empty;
}
