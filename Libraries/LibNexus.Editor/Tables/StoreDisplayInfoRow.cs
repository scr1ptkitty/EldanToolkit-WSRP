using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class StoreDisplayInfoRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("displayType")]
	public uint DisplayType { get; set; }

	[TableColumn("displayValue")]
	public uint DisplayValue { get; set; }

	[TableColumn("modelCameraId")]
	public uint ModelCameraId { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }
}
