using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class RewardRotationContentRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("contentTypeEnum")]
	public uint ContentTypeEnum { get; set; }
}
