using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class Spell4EffectModificationRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("spell4EffectsId")]
	public uint Spell4EffectsId { get; set; }

	[TableColumn("effectTypeEnum")]
	public uint EffectTypeEnum { get; set; }

	[TableColumn("modificationParameterEnum")]
	public uint ModificationParameterEnum { get; set; }

	[TableColumn("priority")]
	public uint Priority { get; set; }

	[TableColumn("modificationTypeEnum")]
	public uint ModificationTypeEnum { get; set; }

	[TableColumn("data00")]
	public float Data00 { get; set; }

	[TableColumn("data01")]
	public float Data01 { get; set; }

	[TableColumn("data02")]
	public float Data02 { get; set; }

	[TableColumn("data03")]
	public float Data03 { get; set; }
}
