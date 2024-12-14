using LibNexus.Files.TableFiles;

namespace LibNexus.Editor.Tables;

public class ItemRuneInstanceRow
{
	[TableColumn("ID")]
	public uint Id { get; set; }

	[TableColumn("definedSocketCount")]
	public uint DefinedSocketCount { get; set; }

	[TableColumn("definedSocketType00")]
	public uint DefinedSocketType00 { get; set; }

	[TableColumn("definedSocketType01")]
	public uint DefinedSocketType01 { get; set; }

	[TableColumn("definedSocketType02")]
	public uint DefinedSocketType02 { get; set; }

	[TableColumn("definedSocketType03")]
	public uint DefinedSocketType03 { get; set; }

	[TableColumn("definedSocketType04")]
	public uint DefinedSocketType04 { get; set; }

	[TableColumn("definedSocketType05")]
	public uint DefinedSocketType05 { get; set; }

	[TableColumn("definedSocketType06")]
	public uint DefinedSocketType06 { get; set; }

	[TableColumn("definedSocketType07")]
	public uint DefinedSocketType07 { get; set; }

	[TableColumn("itemSetId")]
	public uint ItemSetId { get; set; }

	[TableColumn("itemSetPower")]
	public uint ItemSetPower { get; set; }

	[TableColumn("socketCountMax")]
	public uint SocketCountMax { get; set; }
}
