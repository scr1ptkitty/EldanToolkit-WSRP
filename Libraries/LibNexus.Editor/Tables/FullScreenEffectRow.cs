using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class FullScreenEffectRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("description")]
	public string Description { get; set; } = string.Empty;

	[TableColumn("texturePath")]
	public string TexturePath { get; set; } = string.Empty;

	[TableColumn("modelPath")]
	public string ModelPath { get; set; } = string.Empty;

	[TableColumn("priority")]
	public uint Priority { get; set; }

	[TableColumn("fullScreenEffectTypeEnum")]
	public uint FullScreenEffectTypeEnum { get; set; }

	[TableColumn("alphaMinStart")]
	public float AlphaMinStart { get; set; }

	[TableColumn("alphaMinEnd")]
	public float AlphaMinEnd { get; set; }

	[TableColumn("alphaStart")]
	public float AlphaStart { get; set; }

	[TableColumn("alphaEnd")]
	public float AlphaEnd { get; set; }

	[TableColumn("hzStart")]
	public float HzStart { get; set; }

	[TableColumn("hzEnd")]
	public float HzEnd { get; set; }

	[TableColumn("saturationStart")]
	public float SaturationStart { get; set; }

	[TableColumn("saturationEnd")]
	public float SaturationEnd { get; set; }
}
