using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class LanguageRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("languageTag")]
	public string LanguageTag { get; set; } = string.Empty;

	[TableColumn("clientLanguageTag")]
	public string ClientLanguageTag { get; set; } = string.Empty;

	[TableColumn("soundAvailabilityIndexFemale")]
	public uint SoundAvailabilityIndexFemale { get; set; }
}
