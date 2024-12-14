using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EmoteSequenceTransitionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("emotesIdTo")]
	public uint EmotesIdTo { get; set; }

	[TableColumn("standStateFrom")]
	public uint StandStateFrom { get; set; }

	[TableColumn("emotesIdFrom")]
	public uint EmotesIdFrom { get; set; }

	[TableColumn("modelSequenceId")]
	public uint ModelSequenceId { get; set; }
}
