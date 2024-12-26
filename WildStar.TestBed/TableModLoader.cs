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
			HasHeaderRecord = true,
		}))
		{
			// Read the header to map columns
			csv.Read();
			csv.ReadHeader();

			csv.Context.TypeConverterCache.AddConverter<string>(new StringConverter());

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
							newRow.SetValue(column.Key, Convert.ChangeType(value, column.Value));
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
			csv.Context.TypeConverterCache.AddConverter<string>(new StringConverter());

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

	public class StringConverter : CsvHelper.TypeConversion.StringConverter
	{
		public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
		{
			if (string.IsNullOrEmpty(text))
				return null;
			else
				return base.ConvertFromString(text, row, memberMapData);
		}

		public override string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
		{
			if(value == null)
				return "";
			else
				return base.ConvertToString(value, row, memberMapData);
		}
	}
}