using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ClassSecondaryStatBonusRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("unitProperty2IdSecondaryStat00")]
	public uint UnitProperty2IdSecondaryStat00 { get; set; }

	[TableColumn("unitProperty2IdSecondaryStat01")]
	public uint UnitProperty2IdSecondaryStat01 { get; set; }

	[TableColumn("unitProperty2IdSecondaryStat02")]
	public uint UnitProperty2IdSecondaryStat02 { get; set; }

	[TableColumn("modifier00")]
	public float Modifier00 { get; set; }

	[TableColumn("modifier01")]
	public float Modifier01 { get; set; }

	[TableColumn("modifier02")]
	public float Modifier02 { get; set; }
}
