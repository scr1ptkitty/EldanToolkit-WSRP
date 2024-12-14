using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GossipSetRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("gossipProximityEnum")]
	public uint GossipProximityEnum { get; set; }

	[TableColumn("cooldown")]
	public uint Cooldown { get; set; }
}
