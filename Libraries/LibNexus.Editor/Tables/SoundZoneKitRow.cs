using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class SoundZoneKitRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("soundZoneKitIdParent")]
	public uint SoundZoneKitIdParent { get; set; }

	[TableColumn("worldZoneId")]
	public uint WorldZoneId { get; set; }

	[TableColumn("inheritFlags")]
	public uint InheritFlags { get; set; }

	[TableColumn("propertyFlags")]
	public uint PropertyFlags { get; set; }

	[TableColumn("soundMusicSetId")]
	public uint SoundMusicSetId { get; set; }

	[TableColumn("soundEventIdIntro")]
	public uint SoundEventIdIntro { get; set; }

	[TableColumn("introReplayWait")]
	public float IntroReplayWait { get; set; }

	[TableColumn("soundEventIdMusicMood")]
	public uint SoundEventIdMusicMood { get; set; }

	[TableColumn("soundEventIdAmbientDay")]
	public uint SoundEventIdAmbientDay { get; set; }

	[TableColumn("soundEventIdAmbientNight")]
	public uint SoundEventIdAmbientNight { get; set; }

	[TableColumn("soundEventIdAmbientUnderwater")]
	public uint SoundEventIdAmbientUnderwater { get; set; }

	[TableColumn("soundEventIdAmbientStop")]
	public uint SoundEventIdAmbientStop { get; set; }

	[TableColumn("soundEventIdAmbientPreStopOverride")]
	public uint SoundEventIdAmbientPreStopOverride { get; set; }

	[TableColumn("soundEnvironmentId00")]
	public uint SoundEnvironmentId00 { get; set; }

	[TableColumn("soundEnvironmentId01")]
	public uint SoundEnvironmentId01 { get; set; }

	[TableColumn("environmentDry")]
	public float EnvironmentDry { get; set; }

	[TableColumn("environmentWet00")]
	public float EnvironmentWet00 { get; set; }

	[TableColumn("environmentWet01")]
	public float EnvironmentWet01 { get; set; }
}
