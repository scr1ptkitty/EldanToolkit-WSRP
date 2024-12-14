using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace LibNexus.Files.TableFiles;

public class TableWithRows<T> : Table
	where T : notnull
{
	public Dictionary<uint, T> Rows { get; }

	public TableWithRows(Stream stream)
		: base(stream)
	{
		var rows = ReadRows();
		var strings = ReadStrings();
		var idList = ReadIdList();

		FileFormatException.ThrowIf<Table>(nameof(stream), stream.Position != stream.Length);

		Rows = idList.Select(static (id, index) => new { Index = (uint)index, Id = id })
			.ToDictionary(
				static entry => entry.Index,
				entry =>
				{
					if (entry.Id == uint.MaxValue)
						return default;

					rows[entry.Id].SetStrings(strings);

					return rows[entry.Id].Row;
				}
			);
	}

	private (T Row, Action<Dictionary<ulong, string>> SetStrings)[] ReadRows()
	{
		FileFormatException.ThrowIf<Table>(nameof(Header.RowsOffset), Header.RowsOffset != 0 && (ulong)DataStream.Position != Header.RowsOffset);

		var properties = typeof(T).GetProperties()
			.ToDictionary(
				static property => property,
				static property => property.GetCustomAttribute<TableColumnAttribute>() ?? throw new FileFormatException(typeof(T), property.Name)
			);

		var rows = new (T, Action<Dictionary<ulong, string>>)[Header.Rows];

		for (var i = 0U; i < Header.Rows; i++)
		{
			// TODO if we can properly calculate the padding, we can skip the calculation for performance reasons!
			rows[i] = ReadRow(properties, out var rowLength);
			DataStream.ReadBytes(Header.RowLength - rowLength); // TODO Not empty on TradeskillTier ?! TODO does this align to any Padding logic?
		}

		DataStream.SkipPadding(16);

		return rows;
	}

	private (T Row, Action<Dictionary<ulong, string>> SetStrings) ReadRow(Dictionary<PropertyInfo, TableColumnAttribute> properties, out ulong rowLength)
	{
		var row = Activator.CreateInstance<T>();
		var setStrings = new List<Action<Dictionary<ulong, string>>>();
		rowLength = 0;

		foreach (var (name, column) in Columns)
		{
			var property = properties.FirstOrDefault(entry => entry.Value.Name == name).Key ?? throw new FileFormatException(typeof(T), name);

			object value;

			switch (column.Type)
			{
				case TableColumnType.Uint:
					value = DataStream.ReadUInt32();
					rowLength += 4;

					break;

				case TableColumnType.Float:
					value = DataStream.ReadSingle();
					rowLength += 4;

					break;

				case TableColumnType.Bool:
					value = DataStream.ReadUInt32() != 0;
					rowLength += 4;

					break;

				case TableColumnType.Ulong:
					value = DataStream.ReadUInt64();
					rowLength += 8;

					break;

				case TableColumnType.String:
				{
					var offsetOrZero = DataStream.ReadUInt32();
					var textOffset = offsetOrZero != 0 ? offsetOrZero : DataStream.ReadUInt32();
					var unk1 = DataStream.ReadUInt32();

					rowLength += (ulong)(offsetOrZero != 0 ? 8 : 12);
					setStrings.Add(strings => property.SetValue(row, strings[textOffset]));
					value = null;
					FileFormatException.ThrowIf<Table>(nameof(unk1), unk1 != 0);

					break;
				}

				default:
					throw new FileFormatException(typeof(T), nameof(column.Type));
			}

			if (value != null)
				property.SetValue(row, value);
		}

		return (row, strings => setStrings.ForEach(setString => setString(strings)));
	}

	private Dictionary<ulong, string> ReadStrings()
	{
		using var rowsStream = new SegmentStream(DataStream, (long)Header.RowsOffset, (long)Header.RowsLength);

		var strings = new Dictionary<ulong, string>();

		while (rowsStream.Position < rowsStream.Length)
			strings.Add((ulong)rowsStream.Position, DataStream.ReadWideString());

		DataStream.SkipPadding(16);

		return strings;
	}

	private IEnumerable<uint> ReadIdList()
	{
		FileFormatException.ThrowIf<Table>(nameof(Header.IdListOffset), Header.IdListOffset != 0 && (ulong)DataStream.Position != Header.IdListOffset);
		var idList = new uint[Header.AutoIncrement];

		for (var i = 0U; i < Header.AutoIncrement; i++)
			idList[i] = DataStream.ReadUInt32();

		DataStream.SkipPadding(16);

		return idList;
	}
}
