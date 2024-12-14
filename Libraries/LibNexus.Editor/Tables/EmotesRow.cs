using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class EmotesRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("localizedTextIdNoArgToAll")]
	public uint LocalizedTextIdNoArgToAll { get; set; }

	[TableColumn("localizedTextIdNoArgToSelf")]
	public uint LocalizedTextIdNoArgToSelf { get; set; }

	[TableColumn("NoArgAnim")]
	public uint NoArgAnim { get; set; }

	[TableColumn("localizedTextIdArgToAll")]
	public uint LocalizedTextIdArgToAll { get; set; }

	[TableColumn("localizedTextIdArgToArg")]
	public uint LocalizedTextIdArgToArg { get; set; }

	[TableColumn("localizedTextIdArgToSelf")]
	public uint LocalizedTextIdArgToSelf { get; set; }

	[TableColumn("ArgAnim")]
	public uint ArgAnim { get; set; }

	[TableColumn("localizedTextIdSelfToAll")]
	public uint LocalizedTextIdSelfToAll { get; set; }

	[TableColumn("localizedTextIdSelfToSelf")]
	public uint LocalizedTextIdSelfToSelf { get; set; }

	[TableColumn("SelfAnim")]
	public uint SelfAnim { get; set; }

	[TableColumn("SheathWeapons")]
	public bool SheathWeapons { get; set; }

	[TableColumn("TurnToFace")]
	public bool TurnToFace { get; set; }

	[TableColumn("TextReplaceable")]
	public bool TextReplaceable { get; set; }

	[TableColumn("ChangesStandState")]
	public bool ChangesStandState { get; set; }

	[TableColumn("StandState")]
	public uint StandState { get; set; }

	[TableColumn("localizedTextIdCommand")]
	public uint LocalizedTextIdCommand { get; set; }

	[TableColumn("localizedTextIdNotFoundToAll")]
	public uint LocalizedTextIdNotFoundToAll { get; set; }

	[TableColumn("localizedTextIdNotFoundToSelf")]
	public uint LocalizedTextIdNotFoundToSelf { get; set; }

	[TableColumn("NotFoundAnim")]
	public uint NotFoundAnim { get; set; }

	[TableColumn("TextReplaceAnim")]
	public uint TextReplaceAnim { get; set; }

	[TableColumn("modelSequenceIdStandState")]
	public uint ModelSequenceIdStandState { get; set; }

	[TableColumn("visualEffectId")]
	public uint VisualEffectId { get; set; }

	[TableColumn("flags")]
	public uint Flags { get; set; }

	[TableColumn("universalCommand00")]
	public string UniversalCommand00 { get; set; } = string.Empty;

	[TableColumn("universalCommand01")]
	public string UniversalCommand01 { get; set; } = string.Empty;
}
