using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class BinkMovieSubtitleRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("binkMovieId")]
	public uint BinkMovieId { get; set; }

	[TableColumn("delayMs")]
	public uint DelayMs { get; set; }

	[TableColumn("localizedTextIdDisplayText")]
	public uint LocalizedTextIdDisplayText { get; set; }
}
