using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using WildStar.TestBed;

public class DataRowET
{
	public uint UID { get; set; }
	public Dictionary<string, object> Data { get; set; }
}

public class TableWrapper
{
	protected WSTable _table;

	protected Dictionary<int /*index*/, DataRow /*fields*/> _modifiedRows = new();

	protected List<TableDependency> dependencies;

	public List<TableColumn> columns;

	public TableWrapper(WSTable table)
	{
		_table = table ?? throw new ArgumentNullException(nameof(table));
	}

	public DataRow GetRowByUID(int index)
	{
		if(_modifiedRows.TryGetValue(index, out DataRow modifiedRow))
		{
			return modifiedRow;
		}

		var row = _table.Rows.Find(index);
		if (row != null)
		{
			return row;
		}

		throw new KeyNotFoundException($"Row with index '{index}' not found.");
	}

	public DataRow NewRow(int uid)
	{
		if (_modifiedRows.ContainsKey(uid))
			throw new InvalidOperationException($"A row with UID {uid} already exists in the modified rows.");

		DataRow row = _table.NewRow();	// Create a new row matching the schema
		_modifiedRows[uid] = row;		// Store it in the dictionary
		return row;
	}

	public DataRow CopyRow(int uid, int originalRowId)
	{
		if (_modifiedRows.ContainsKey(uid))
			throw new InvalidOperationException($"A row with UID {uid} already exists in the modified rows.");

		DataRow originalRow = _table.Rows.Find(originalRowId); // Find the original row by ID
		if (originalRow == null)
			throw new ArgumentException($"No row found with ID {originalRowId}.");

		DataRow newRow = _table.NewRow(); // Create a new detached row
		newRow.ItemArray = (object[])originalRow.ItemArray.Clone(); // Copy values from the original row

		_modifiedRows[uid] = newRow; // Store the new row in the dictionary
		return newRow;
	}

	public void ReadModifiedRowsFromCsv(string filePath)
	{
		using (var reader = new StreamReader(filePath))
		using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
		{
			HasHeaderRecord = true
		}))
		{
			// Read the header to map columns
			csv.Read();
			csv.ReadHeader();

			while (csv.Read())
			{
				int uid = csv.GetField<int>("UID");

				// Create a new row matching the table schema
				DataRow newRow = _table.NewRow();

				foreach (DataColumn column in _table.Columns)
				{
					if (csv.TryGetField(column.ColumnName, out string value))
					{
						newRow[column] = string.IsNullOrEmpty(value) ? DBNull.Value : Convert.ChangeType(value, column.DataType);
					}
				}

				// Add the row to modified rows
				_modifiedRows[uid] = newRow;
			}
		}
	}

	public void WriteModifiedRowsToCsv(string filePath)
	{
		using (var writer = new StreamWriter(filePath))
		using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
		{
			// Write header
			csv.WriteField("UID");
			foreach (DataColumn column in _table.Columns)
				csv.WriteField(column.ColumnName);
			csv.NextRecord();

			// Write modified rows
			foreach (var entry in _modifiedRows)
			{
				int uid = entry.Key;
				DataRow row = entry.Value;

				csv.WriteField(uid);
				foreach (var item in row.ItemArray)
					csv.WriteField(item);
				csv.NextRecord();
			}
		}
	}

	private void ApplyChangesToTable()
	{
		foreach (var entry in _modifiedRows)
		{
			int uid = entry.Key;
			DataRow modifiedRow = entry.Value;

			// Check if the original table has a row with the same ID
			int id = (int)modifiedRow["ID"]; // "ID" is the primary key column
			DataRow targetRow = _table.Rows.Find(id);

			if (targetRow == null)
			{
				targetRow = _table.NewRow();
				_table.Rows.Add(targetRow);
			}

			// Copy data to the row
			foreach (DataColumn column in _table.Columns)
			{
				targetRow[column.ColumnName] = modifiedRow[column.ColumnName];
			}
		}
	}
}

public record struct TableDependency
{
	public TableWrapper otherTable;
	public int localColumn;
	public int otherColumn;
	public bool refersToOther;
}