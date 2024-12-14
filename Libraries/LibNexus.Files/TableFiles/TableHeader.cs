using LibNexus.Core.Extensions;
using System.IO;

namespace LibNexus.Files.TableFiles;

public class TableHeader
{
	public const long Size = 88;

	public ulong NameLength { get; }
	public ulong NameOffset { get; }
	public ulong RowLength { get; }
	public ulong Columns { get; }
	public ulong ColumnsOffset { get; }
	public ulong Rows { get; }
	public ulong RowsLength { get; }
	public ulong RowsOffset { get; }
	public ulong AutoIncrement { get; }
	public ulong IdListOffset { get; }

	public TableHeader(Stream stream)
	{
		NameLength = stream.ReadUInt64();
		NameOffset = stream.ReadUInt64();
		RowLength = stream.ReadUInt64();
		Columns = stream.ReadUInt64();
		ColumnsOffset = stream.ReadUInt64();
		Rows = stream.ReadUInt64();
		RowsLength = stream.ReadUInt64();
		RowsOffset = stream.ReadUInt64();
		AutoIncrement = stream.ReadUInt64();
		IdListOffset = stream.ReadUInt64();

		FileFormatException.ThrowIf<Table>("unused", stream.ReadUInt64() != 0);
	}
}
