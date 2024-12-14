using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ModelSequenceByWeaponRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("modelSequenceId")]
	public uint ModelSequenceId { get; set; }

	[TableColumn("modelSequenceId1H")]
	public uint ModelSequenceId1H { get; set; }

	[TableColumn("modelSequenceId2H")]
	public uint ModelSequenceId2H { get; set; }

	[TableColumn("modelSequenceId2HL")]
	public uint ModelSequenceId2Hl { get; set; }

	[TableColumn("modelSequenceId2HGun")]
	public uint ModelSequenceId2HGun { get; set; }

	[TableColumn("modelSequenceIdPistols")]
	public uint ModelSequenceIdPistols { get; set; }

	[TableColumn("modelSequenceIdClaws")]
	public uint ModelSequenceIdClaws { get; set; }

	[TableColumn("modelSequenceIdShockPaddles")]
	public uint ModelSequenceIdShockPaddles { get; set; }

	[TableColumn("modelSequenceIdEsper")]
	public uint ModelSequenceIdEsper { get; set; }

	[TableColumn("modelSequenceIdPsyblade")]
	public uint ModelSequenceIdPsyblade { get; set; }

	[TableColumn("modelSequenceIdHeavygun")]
	public uint ModelSequenceIdHeavygun { get; set; }
}
