using CsvHelper.Configuration;
using CsvHelper;
using LibNexus.Files.TableFiles;
using System.Data;
using System.Globalization;
using System.IO;
using System;
using System.Linq;

public static class TableModLoader
{
	public static DataTable Load(string path)
	{
		DataTable table = new DataTable();
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
						newRow.SetValue(column.Key, string.IsNullOrEmpty(value) ? null : Convert.ChangeType(value, column.Value));
					}
				}

				// Add the row to modified rows
				table.InsertRow(uid, newRow);
			}
		}
		return table;
	}

	public static void WriteModifiedRowsToCsv(DataTable table, string path)
	{
		using (var writer = new StreamWriter(path))
		using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
		{
			// Write header
			csv.WriteField("UID");
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
					csv.WriteField(Convert.ChangeType(row.GetValue<object>(column.Key), column.Value));
				csv.NextRecord();
			}
		}
	}
}