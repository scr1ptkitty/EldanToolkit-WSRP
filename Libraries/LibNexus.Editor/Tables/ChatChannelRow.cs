using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ChatChannelRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("enumName")]
	public string EnumName { get; set; } = string.Empty;

	[TableColumn("universalCommand00")]
	public string UniversalCommand00 { get; set; } = string.Empty;

	[TableColumn("universalCommand01")]
	public string UniversalCommand01 { get; set; } = string.Empty;

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("localizedTextIdCommand")]
	public uint LocalizedTextIdCommand { get; set; }

	[TableColumn("localizedTextIdAbbreviation")]
	public uint LocalizedTextIdAbbreviation { get; set; }

	[TableColumn("localizedTextIdAlternate00")]
	public uint LocalizedTextIdAlternate00 { get; set; }

	[TableColumn("localizedTextIdAlternate01")]
	public uint LocalizedTextIdAlternate01 { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
