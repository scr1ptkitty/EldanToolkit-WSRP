using EldanToolkit.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

public class DataTable
{
	public GameTableName TableName { get; set; }
	public Dictionary<string, Type> schema = new();
	public Dictionary<uint, DataRow> rows = new();
	private DataTable fallbackTable = null; // to allow a DataTable to store modifications to another table.
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
		Name = fallback.Name;
		TableName = fallback.TableName;
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
		if (fallbackTable != null)
		{
			row.fallback = fallbackTable.GetRow(id, false);
		}
		rows.Add(id, row);
	}

	public void InsertCopyIfDifferent(uint id, DataRow row)
	{
		var fallbackRow = fallbackTable?.GetRow(id, false);
		// If we have a row, just modify it.
		if (rows.ContainsKey(id))
		{
			rows[id] = new DataRow(fallbackRow, row); // copy
			return;
		}
		// If we don't have a row, but the fallback table has one, check if it's different.
		if (fallbackTable != null && fallbackTable.rows.TryGetValue(id, out DataRow oldRow))
		{
			if (row.Equals(oldRow))
			{
				return;
			}
			rows[id] = new DataRow(fallbackRow, row);
		}
		// We don't have the row in the fallback table either, add it to mods.
		rows[id] = new DataRow(fallbackRow, row);
	}

	// Get a row by index
	public DataRow GetRow(uint index, bool createMod = false)
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
				if (createMod)
				{
					row = new DataRow(row); // new mod row
					rows[index] = row;
				}
				return row;
			}
		}

		return null;
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
			columnExtraData[column] = columnData;
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

public class DataRow : IEquatable<DataRow>
{
	private Dictionary<string, object> columns = new();
	private Dictionary<string, Type> schema;
	public DataRow fallback;

	public DataRow(Dictionary<string, Type> schema)
	{
		this.schema = schema ?? throw new ArgumentNullException(nameof(schema));
	}

	public DataRow(DataRow fallback, DataRow other = null)
	{
		this.fallback = fallback;
		schema = fallback?.schema ?? other.schema; // just allow error if we ever pass both as null
		foreach(var cell in other.columns)
		{
			var myCell = GetValueRaw(cell.Key);
			if (myCell == null || !myCell.Equals(cell.Value))
			{
				columns[cell.Key] = cell.Value; // Different, so we override it.
			}
		}
	}

	public bool Equals(DataRow other)
	{
		if (other == null) return false;

		if (!other.columns.Keys.ToHashSet().SetEquals(columns.Keys.ToHashSet())) return false;
		foreach (var column in columns)
		{
			if (!column.Equals(other.columns[column.Key])) return false;
		}

		return true;
	}

	public void SetValue(string columnName, object value)
	{
		if (!schema.TryGetValue(columnName, out var expectedType))
		{
			throw new InvalidOperationException($"Column '{columnName}' is not defined in the schema.");
		}

		if (!expectedType.IsAssignableFrom(value.GetType()))
		{
			throw new InvalidCastException(
				$"Cannot assign value of type {value.GetType().Name} to column '{columnName}' of type {expectedType.Name}."
			);
		}

		columns[columnName] = Convert.ChangeType(value, expectedType);
	}

	public object GetValueRaw(string columnName)
	{
		if (!columns.TryGetValue(columnName, out object val))
		{
			val = fallback?.GetValueRaw(columnName);
		}
		return val;
	}

	// Get a value with type safety
	public T GetValue<T>(string columnName)
	{
		object val = GetValueRaw(columnName);
		if (val == null)
		{
			throw new KeyNotFoundException($"Column '{columnName}' not found.");
		}
		if (val is T typedValue)
		{
			return typedValue;
		}
		else
		{
			throw new InvalidCastException(
				$"Cannot cast column '{columnName}' value to type {typeof(T).Name}."
			);
		}
	}

	public bool HasValue(string columnName)
	{
		return columns.ContainsKey(columnName);
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