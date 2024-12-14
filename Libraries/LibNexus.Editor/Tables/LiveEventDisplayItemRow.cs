using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LiveEventDisplayItemRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("liveEventId")]
	public uint LiveEventId { get; set; }

	[TableColumn("item2Id")]
	public uint Item2Id { get; set; }

	[TableColumn("storeLinkId")]
	public uint StoreLinkId { get; set; }
}
