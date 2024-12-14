using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4ReagentRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("reagentType")]
	public uint ReagentType { get; set; }

	[TableColumn("reagentTypeObjectId")]
	public uint ReagentTypeObjectId { get; set; }

	[TableColumn("reagentCount")]
	public uint ReagentCount { get; set; }

	[TableColumn("consumeReagent")]
	public bool ConsumeReagent { get; set; }
}
