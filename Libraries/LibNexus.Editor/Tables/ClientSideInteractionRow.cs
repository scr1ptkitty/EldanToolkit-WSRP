using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ClientSideInteractionRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("interactionType")]
	public uint InteractionType { get; set; }

	[TableColumn("threshold")]
	public uint Threshold { get; set; }

	[TableColumn("duration")]
	public uint Duration { get; set; }

	[TableColumn("incrementValue")]
	public uint IncrementValue { get; set; }

	[TableColumn("windowSize")]
	public uint WindowSize { get; set; }

	[TableColumn("decay")]
	public uint Decay { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("tapTime0")]
	public uint TapTime0 { get; set; }

	[TableColumn("tapTime1")]
	public uint TapTime1 { get; set; }

	[TableColumn("visualEffectId0")]
	public uint VisualEffectId0 { get; set; }

	[TableColumn("visualEffectId1")]
	public uint VisualEffectId1 { get; set; }

	[TableColumn("visualEffectId2")]
	public uint VisualEffectId2 { get; set; }

	[TableColumn("visualEffectId3")]
	public uint VisualEffectId3 { get; set; }

	[TableColumn("visualEffectIdTarget00")]
	public uint VisualEffectIdTarget00 { get; set; }

	[TableColumn("visualEffectIdTarget01")]
	public uint VisualEffectIdTarget01 { get; set; }

	[TableColumn("visualEffectIdTarget02")]
	public uint VisualEffectIdTarget02 { get; set; }

	[TableColumn("visualEffectIdTarget03")]
	public uint VisualEffectIdTarget03 { get; set; }

	[TableColumn("visualEffectIdTarget04")]
	public uint VisualEffectIdTarget04 { get; set; }

	[TableColumn("visualEffectIdCaster00")]
	public uint VisualEffectIdCaster00 { get; set; }

	[TableColumn("visualEffectIdCaster01")]
	public uint VisualEffectIdCaster01 { get; set; }

	[TableColumn("visualEffectIdCaster02")]
	public uint VisualEffectIdCaster02 { get; set; }

	[TableColumn("visualEffectIdCaster03")]
	public uint VisualEffectIdCaster03 { get; set; }

	[TableColumn("visualEffectIdCaster04")]
	public uint VisualEffectIdCaster04 { get; set; }

	[TableColumn("localizedTextIdContext")]
	public uint LocalizedTextIdContext { get; set; }
}
