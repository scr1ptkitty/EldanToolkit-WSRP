using CsvHelper.Configuration;
using CsvHelper;
using LibNexus.Files.TableFiles;
using System.Data;
using System.Globalization;
using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata;

public static class TableModLoader
{
	public static DataTable Load(string path, DataTable baseTable)
	{
		DataTable table = new DataTable(baseTable);
		using (var reader = new StreamReader(path))
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
				uint uid = csv.GetField<uint>("UID");

				// Create a new row matching the table schema
				DataRow newRow = table.NewRow();

				foreach (var column in table.schema)
				{
					if (csv.TryGetField(column.Key, out string value))
					{
						if (value != null)
						{
							newRow.SetValueRaw(column.Key, Convert.ChangeType(value, column.Value));
						}
						else
						{

						}
					}
				}

				// Add the row to modified rows
				table.InsertRow(uid, newRow);
			}
		}
		return table;
	}

	public static void Write(DataTable table, string path)
	{
		using (var writer = new StreamWriter(path))
		using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
		{
			// Write header
			var schema = table.schema.ToList();
			foreach (var column in schema)
				csv.WriteField(column.Key);
			csv.NextRecord();

			// Write modified rows
			foreach (var entry in table.rows)
			{
				uint uid = entry.Key;
				DataRow row = entry.Value;

				foreach (var column in schema)
				{
					if (row.HasValue(column.Key) || column.Key == "UID")
					{
						csv.WriteField(Convert.ChangeType(row.GetValue<object>(column.Key), column.Value).ToString(), table.schema[column.Key] == typeof(string));
					}
					else
					{
						csv.WriteField(null, false);
					}
				}
				csv.NextRecord();
			}
		}
	}
}