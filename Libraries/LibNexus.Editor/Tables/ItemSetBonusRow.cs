using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemSetBonusRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("requiredPower")]
	public uint RequiredPower { get; set; }

	[TableColumn("unitProperty2Id")]
	public uint UnitProperty2Id { get; set; }

	[TableColumn("scalar")]
	public float Scalar { get; set; }

	[TableColumn("offset")]
	public float Offset { get; set; }

	[TableColumn("spell4Id")]
	public uint Spell4Id { get; set; }
}
