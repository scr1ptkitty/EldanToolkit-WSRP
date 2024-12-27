using System.Collections.Generic;
using System;
using System.IO;
using System.Xml.Serialization;
using Godot;
using EldanToolkit.Shared;

public class TableStructure
{
	public TableStructure(TableDataXML xml)
	{
		Description = xml.Description;
		Columns = new();
		foreach (var c in xml.Columns)
		{
			Columns[c.Name] = c;
		}
		DefaultEditorDescriptionColumn = xml.DefaultEditorDescriptionColumn;
	}

	public TableStructure(GameTableName tableName)
	{
		Description = tableName.ToString();
		Columns = new(); // Undefined columns just get a default.
		DefaultEditorDescriptionColumn = "Description";
	}

	public string Description;
	public Dictionary<string, TableColumn> Columns;
	public string DefaultEditorDescriptionColumn;

	public string GetEntryDescription(DataRow row, TableDataSet set)
	{
		string EntryDescription = row.GetValue<string>("EditorDescription");
		if (string.IsNullOrWhiteSpace(EntryDescription))
		{
			EntryDescription = GetFieldPreview(row, DefaultEditorDescriptionColumn, set);
		}
		return EntryDescription;
	}

	public string GetFieldPreview(DataRow row, string column, TableDataSet set)
	{
		if (Columns.TryGetValue(column, out TableColumn tableColumn))
		{
			GameTableName refTable;
			string refColumn;
			switch (tableColumn.Type)
			{
				case TableColumn.ColumnType.Reference:
					refTable = tableColumn.RefTable.Value;
					refColumn = tableColumn.RefColumn;
					break;
				case TableColumn.ColumnType.LocalizedTextID:
					refTable = GameTableName.enUS;
					refColumn = "Text";
					break;
				default:
					return null;
			}
			DataTable rt = set.GetTable(refTable);
			uint refID = row.GetValue<uint>(column);
			DataRow refRow = rt.GetRow(refID);
			TableStructure refStructure = GetStructure(refTable);
			return refStructure.GetFieldPreview(refRow, refColumn, set) ?? refRow.GetValueRaw(refColumn).ToString();
		}
		return null;
	}

	// static stuff
	public static Dictionary<GameTableName, TableStructure> TableColumnDefs { get; private set; } = LoadAllColumns();

	public static Dictionary<GameTableName, TableStructure> LoadAllColumns()
	{
		var tableColumns = new Dictionary<GameTableName, TableStructure>();

		string folderPath = ProjectSettings.GlobalizePath("res://TableStructure");

		// Iterate over all XML files in the folder
		foreach (var file in Directory.GetFiles(folderPath, "*.xml"))
		{
			if (Enum.TryParse(Path.GetFileNameWithoutExtension(file), out GameTableName tableName))
			{
				var columns = LoadColumnData(file);
				tableColumns[tableName] = columns;
			}
		}

		return tableColumns;
	}

	private static TableStructure LoadColumnData(string filePath)
	{
		var serializer = new XmlSerializer(typeof(TableDataXML));
		using var stream = new FileStream(filePath, FileMode.Open);
		var columnData = (TableDataXML)serializer.Deserialize(stream);

		return new TableStructure(columnData);
	}

	public static TableStructure GetStructure(GameTableName tableName)
	{
		if (TableColumnDefs.TryGetValue(tableName, out TableStructure tableStructure))
		{
			return tableStructure;
		}
		tableStructure = new TableStructure(tableName);
		TableColumnDefs[tableName] = tableStructure;
		return tableStructure;
	}
}

[XmlRoot("TableData")]
public class TableDataXML
{
	[XmlElement("Description")]
	public string Description { get; set; }

	[XmlElement("DefaultEditorDescriptionColumn")]
	public string DefaultEditorDescriptionColumn { get; set; } // The column to use to fill in the displayed name of entries.

	[XmlElement("Column")]
	public List<TableColumn> Columns { get; set; } = new List<TableColumn>();
}

public class TableColumn
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("ColumnType")]
    public ColumnType Type { get; set; } = ColumnType.Default;

    [XmlElement("AssetFormat")]
    public string AssetFormat { get; set; }

	[XmlElement("RefTable")]
	public GameTableName? RefTable { get; set; }

    [XmlElement("RefColumn")]
    public string RefColumn { get; set; }

    [XmlElement("Tooltip")]
    public string Tooltip { get; set; }

    public enum ColumnType
    {
        Default,
        ID,
        LocalizedTextID,
        AssetPath,
        Reference,
        Flags
    }
}