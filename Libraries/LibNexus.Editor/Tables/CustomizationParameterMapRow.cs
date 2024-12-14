using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class CustomizationParameterMapRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("raceId")]
	public uint RaceId { get; set; }

	[TableColumn("genderEnum")]
	public uint GenderEnum { get; set; }

	[TableColumn("modelBoneId")]
	public uint ModelBoneId { get; set; }

	[TableColumn("customizationParameterId")]
	public uint CustomizationParameterId { get; set; }

	[TableColumn("dataOrder")]
	public uint DataOrder { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }
}
