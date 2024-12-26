using EldanToolkit.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

public class DataTable
{
	public GameTableName TableName { get; set; }
	public Dictionary<string, Type> schema = new();
	public Dictionary<uint, DataRow> rows = new();
	public DataTable fallbackTable = null; // to allow a DataTable to store modifications to another table.
	public string Name;
	private Dictionary<string, object> extraData = new();
	private Dictionary<string, Dictionary<string, object>> columnExtraData = new();

	public DataTable()
	{
	}

	public DataTable(DataTable fallback)
	{
		schema = new Dictionary<string, Type>(fallback.schema);
		fallbackTable = fallback;
	}

	public void SetColumn(string name, Type type)
	{
		schema[name] = type;
	}

	public DataRow NewRow()
	{
		return new DataRow(schema);
	}

	// Add a new row
	public void InsertRow(uint id, DataRow row)
	{
		if (rows.ContainsKey(id)) throw new InvalidOperationException("Tried to add a row with an ID that was already filled");
		rows.Add(id, row);
	}

	// Get a row by index
	public DataRow GetRow(uint index)
	{
		if (rows.TryGetValue(index, out var row))
		{
			return row;
		}

		if (fallbackTable != null)
		{
			row = fallbackTable.GetRow(index);
			if(row != null)
			{
				row = new DataRow(row); // new mod row
				rows[index] = row;
				return row;
			}
		}

		throw new IndexOutOfRangeException($"Row index {index} is out of range.");
	}

	// Remove a row by index
	public void RemoveRow(uint index)
	{
		if (index >= 0 && index < rows.Count)
		{
			rows.Remove(index);
			return;
		}

		throw new IndexOutOfRangeException($"Row index {index} is out of range.");
	}

	public T GetUserData<T>(string key)
	{
		if (extraData.TryGetValue(key, out var data))
		{
			return (T)data;
		}
		if (fallbackTable != null)
		{
			return fallbackTable.GetUserData<T>(key);
		}
		throw new InvalidOperationException("Tried to get table userdata that does not exist");
	}

	public void SetUserData<T>(string key, T data)
	{
		extraData[key] = data;
	}

	public T GetColumnUserData<T>(string column, string key)
	{
		if(columnExtraData.TryGetValue(column, out var columnData))
		{
			if(columnData.TryGetValue(key, out var data))
			{
				return (T)data;
			}
		}
		if (fallbackTable != null)
		{
			return fallbackTable.GetColumnUserData<T>(column, key);
		}
		throw new InvalidOperationException("Tried to get column userdata that does not exist");
	}

	public void SetColumnUserData<T>(string column, string key, T data)
	{
		if(!columnExtraData.TryGetValue(column, out var columnData))
		{
			columnData = new();
			extraData[column] = columnData;
		}
		columnData[key] = data;
	}

	public uint GetMaxID(bool fallback = true)
	{
		return GetRowList(fallback).Max(r => r.Key);
	}

	public IEnumerable<KeyValuePair<uint, DataRow>> GetRowList(bool fallback = true)
	{
		if (fallbackTable == null || !fallback)
		{
			return rows;
		}
		return rows.UnionBy(fallbackTable.rows, k => k.Key);
	}
}

public class DataRow
{
	private Dictionary<string, object> columns;
	private Dictionary<string, Type> schema;

	public DataRow(Dictionary<string, Type> schema)
	{
		this.schema = schema ?? throw new ArgumentNullException(nameof(schema));
		columns = new Dictionary<string, object>();
	}

	public DataRow(DataRow other)
	{
		columns = new Dictionary<string, object>(other.columns);
		schema = other.schema;
	}

	public void SetValueRaw(string columnName, object value)
	{
		if (!schema.TryGetValue(columnName, out var expectedType))
		{
			throw new InvalidOperationException($"Column '{columnName}' is not defined in the schema.");
		}

		columns[columnName] = Convert.ChangeType(value, expectedType);
	}

	// Set a value with schema enforcement
	public void SetValue<T>(string columnName, T value)
	{
		if (!schema.TryGetValue(columnName, out var expectedType))
		{
			throw new InvalidOperationException($"Column '{columnName}' is not defined in the schema.");
		}

		if (!expectedType.IsAssignableFrom(typeof(T)))
		{
			throw new InvalidCastException(
				$"Cannot assign value of type {typeof(T).Name} to column '{columnName}' of type {expectedType.Name}."
			);
		}

		columns[columnName] = value!;
	}

	// Get a value with type safety
	public T GetValue<T>(string columnName)
	{
		if (columns.TryGetValue(columnName, out var value))
		{
			if (value is T typedValue)
			{
				return typedValue;
			}

			throw new InvalidCastException(
				$"Cannot cast column '{columnName}' value to type {typeof(T).Name}."
			);
		}

		throw new KeyNotFoundException($"Column '{columnName}' not found.");
	}

	public Type GetType(string columnName)
	{
		if(schema.TryGetValue(columnName, out Type type))
		{
			return type;
		}
		throw new InvalidOperationException("No such column exists.");
	}
}