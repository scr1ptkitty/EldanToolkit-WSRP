using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CustomerSurveyRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("customerSurveyTypeEnum")]
	public uint CustomerSurveyTypeEnum { get; set; }

	[TableColumn("localizedTextIdOverrideTitle")]
	public uint LocalizedTextIdOverrideTitle { get; set; }

	[TableColumn("localizedTextIdQuestion00")]
	public uint LocalizedTextIdQuestion00 { get; set; }

	[TableColumn("localizedTextIdQuestion01")]
	public uint LocalizedTextIdQuestion01 { get; set; }

	[TableColumn("localizedTextIdQuestion02")]
	public uint LocalizedTextIdQuestion02 { get; set; }
}
