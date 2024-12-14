using System.Collections.Generic;
using System;
using System.IO;
using System.Xml.Serialization;
using Godot;

public class TableStructure
{
	public TableStructure(string description, Dictionary<string, TableColumn> columns)
	{
		Description = description;
		Columns = columns;
	}

	public string Description;
	public Dictionary<string, TableColumn> Columns;

	public static Dictionary<TableName, TableStructure> TableColumnDefs { get; private set; } = LoadAllColumns();

	public static Dictionary<TableName, TableStructure> LoadAllColumns()
	{
		var tableColumns = new Dictionary<TableName, TableStructure>();

		string folderPath = ProjectSettings.GlobalizePath("res://TableStructure");

		// Iterate over all XML files in the folder
		foreach (var file in Directory.GetFiles(folderPath, "*.xml"))
		{
			if (Enum.TryParse(Path.GetFileNameWithoutExtension(file), out TableName tableName))
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

		var columns = new Dictionary<string, TableColumn>();
		foreach (var column in columnData.Columns)
		{
			columns[column.Name] = column;
		}

		return new TableStructure(columnData.Description, columns);
	}
}

[XmlRoot("TableData")]
public class TableDataXML
{
	[XmlElement("Description")]
	public string Description { get; set; }

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
    public TableName RefTable { get; set; } = TableName.Unknown;

    [XmlElement("RefColumn")]
    public int RefColumn { get; set; }

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

public enum TableName
{
	CharacterCustomization,
	CharacterCustomizationLabel,
	CharacterCustomizationSelection,
	ColorShift,
	Creature2,
	Creature2DisplayGroupEntry,
	Creature2DisplayInfo,
	Creature2OutfitGroupEntry,
	Creature2OutfitInfo,
	DyeColorRamp,
	Emotes,
	HookAsset,
	HousingDecorInfo,
	HousingDecorType,
	HousingPlugItem,
	HousingWallpaperInfo,
	Item2,
	ItemColorSet,
	ItemDisplay,
	ItemSpecial,
	Spell4,
	Spell4Base,
	Spell4Effects,
	UnitVehicle,
	WorldLayer,
	Localization,
	Unknown
}