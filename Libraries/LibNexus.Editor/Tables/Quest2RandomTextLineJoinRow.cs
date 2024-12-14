using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Quest2RandomTextLineJoinRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("quest2Id")]
	public uint Quest2Id { get; set; }

	[TableColumn("questVOTextType")]
	public uint QuestVoTextType { get; set; }

	[TableColumn("randomTextLineId")]
	public uint RandomTextLineId { get; set; }
}
