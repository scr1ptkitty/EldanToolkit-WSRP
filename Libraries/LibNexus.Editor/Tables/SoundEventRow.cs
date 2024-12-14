using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundEventRow
{
	[TableColumn("id")]
	public uint Id { get; set; }

	[TableColumn("name")]
	public string Name { get; set; } = string.Empty;

	[TableColumn("hash")]
	public uint Hash { get; set; }

	[TableColumn("radius")]
	public float Radius { get; set; }

	[TableColumn("soundBankId00")]
	public uint SoundBankId00 { get; set; }

	[TableColumn("soundBankId01")]
	public uint SoundBankId01 { get; set; }

	[TableColumn("soundBankId02")]
	public uint SoundBankId02 { get; set; }

	[TableColumn("soundBankId03")]
	public uint SoundBankId03 { get; set; }

	[TableColumn("soundBankId04")]
	public uint SoundBankId04 { get; set; }

	[TableColumn("soundBankId05")]
	public uint SoundBankId05 { get; set; }

	[TableColumn("soundBankId06")]
	public uint SoundBankId06 { get; set; }

	[TableColumn("soundBankId07")]
	public uint SoundBankId07 { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("limitPriority")]
	public uint LimitPriority { get; set; }
}
