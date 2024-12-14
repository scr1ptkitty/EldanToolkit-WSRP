using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CustomizationParameterRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("sclX")]
	public uint SclX { get; set; }

	[TableColumn("sclY")]
	public uint SclY { get; set; }

	[TableColumn("sclZ")]
	public uint SclZ { get; set; }

	[TableColumn("rotX")]
	public uint RotX { get; set; }

	[TableColumn("rotY")]
	public uint RotY { get; set; }

	[TableColumn("rotZ")]
	public uint RotZ { get; set; }

	[TableColumn("posX")]
	public uint PosX { get; set; }

	[TableColumn("posY")]
	public uint PosY { get; set; }

	[TableColumn("posZ")]
	public uint PosZ { get; set; }
}
