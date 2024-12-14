using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class StoreKeywordRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("storeDisplayInfoId")]
	public uint StoreDisplayInfoId { get; set; }

	[TableColumn("keyword")]
	public string Keyword { get; set; } = string.Empty;
}
