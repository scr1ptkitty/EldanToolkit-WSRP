using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class PublicEventUnitPropertyModifierRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("publicEventId")]
	public uint PublicEventId { get; set; }

	[TableColumn("unitProperty2Id")]
	public uint UnitProperty2Id { get; set; }

	[TableColumn("scalar")]
	public float Scalar { get; set; }
}
