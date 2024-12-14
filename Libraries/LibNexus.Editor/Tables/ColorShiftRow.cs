using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ColorShiftRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("texturePath")]
	public string TexturePath { get; set; } = string.Empty;

	[TableColumn("localizedTextId")]
	public uint LocalizedTextId { get; set; }

	[TableColumn("previewSwatchIcon")]
	public string PreviewSwatchIcon { get; set; } = string.Empty;
}
