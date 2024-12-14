using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventVirtualItemDepotRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("creature2Id")]
	public uint Creature2Id { get; set; }

	[TableColumn("virtualItemId00")]
	public uint VirtualItemId00 { get; set; }

	[TableColumn("virtualItemId01")]
	public uint VirtualItemId01 { get; set; }

	[TableColumn("virtualItemId02")]
	public uint VirtualItemId02 { get; set; }

	[TableColumn("virtualItemId03")]
	public uint VirtualItemId03 { get; set; }

	[TableColumn("virtualItemId04")]
	public uint VirtualItemId04 { get; set; }

	[TableColumn("virtualItemId05")]
	public uint VirtualItemId05 { get; set; }
}
