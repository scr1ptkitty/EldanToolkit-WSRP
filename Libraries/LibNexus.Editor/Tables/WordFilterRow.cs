using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class WordFilterRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("filter")]
	public string Filter { get; set; } = string.Empty;

	[TableColumn("userTextFilterClassEnum")]
	public uint UserTextFilterClassEnum { get; set; }

	[TableColumn("deploymentRegionEnum")]
	public uint DeploymentRegionEnum { get; set; }

	[TableColumn("languageId")]
	public uint LanguageId { get; set; }

	[TableColumn("wordFilterTypeEnum")]
	public uint WordFilterTypeEnum { get; set; }
}
