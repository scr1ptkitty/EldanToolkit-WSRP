using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class GuildStandardPartRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("guildStandardPartTypeEnum")]
	public uint GuildStandardPartTypeEnum { get; set; }

	[TableColumn("localizedTextIdName")]
	public uint LocalizedTextIdName { get; set; }

	[TableColumn("itemDisplayIdStandard")]
	public uint ItemDisplayIdStandard { get; set; }
}
