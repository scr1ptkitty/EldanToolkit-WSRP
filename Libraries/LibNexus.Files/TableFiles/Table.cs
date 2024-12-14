using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibNexus.Files.TableFiles;

public abstract class Table
{
	private static readonly Identifier Identifier = new("DTBL", 0);

	protected Stream DataStream { get; }

	protected TableHeader Header { get; }

	public string Name { get; }
	public Dictionary<string, TableColumn> Columns { get; }

	protected Table(Stream stream)
	{
		FileFormatException.ThrowIf<Table>(nameof(Identifier), new Identifier(stream) != Identifier);

		Header = new TableHeader(stream);

		DataStream = new SegmentStream(stream);

		Name = ReadName();
		var columns = ReadColumns();
		var strings = ReadStrings();

		Columns = columns.ToDictionary(column => strings[column.NameOffset], static column => column);
	}

	private string ReadName()
	{
		FileFormatException.ThrowIf<Table>(nameof(Header.NameOffset), (ulong)DataStream.Position != Header.NameOffset);
		var name = DataStream.ReadWideString(Header.NameLength);
		DataStream.SkipPadding(16);

		return name;
	}

	private IEnumerable<TableColumn> ReadColumns()
	{
		FileFormatException.ThrowIf<Table>(nameof(Header.ColumnsOffset), (ulong)DataStream.Position != Header.ColumnsOffset);
		var columns = new TableColumn[Header.Columns];

		for (var i = 0UL; i < Header.Columns; i++)
			columns[i] = new TableColumn(DataStream);

		DataStream.SkipPadding(16);

		return columns;
	}

	private Dictionary<ulong, string> ReadStrings()
	{
		using var stringsStream = new SegmentStream(DataStream);
		var strings = new Dictionary<ulong, string>();

		for (var i = 0UL; i < Header.Columns; i++)
		{
			strings.Add((ulong)stringsStream.Position, stringsStream.ReadWideString());
			stringsStream.SkipPadding(16);
		}

		return strings;
	}
}
