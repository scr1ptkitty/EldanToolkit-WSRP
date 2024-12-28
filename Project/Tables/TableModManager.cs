using EldanToolkit.Project;
using EldanToolkit.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.XPath;
using WildStar.GameTable;
using WildStar.TextTable;

public class TableModManager : TableDataSet
{
	public Project Project { get; private set; }
	private Dictionary<GameTableName, DataTable> tableMods = new();
	public TableDataSet BaseSet { get; private set; }

	public TableModManager(Project project, TableDataSet baseSet)
	{
		Project = project;
		BaseSet = baseSet;
	}

	public DataTable GetTable(GameTableName tableName)
	{
		if(tableMods.TryGetValue(tableName, out DataTable table))
		{
			return table;
		}
		var baseTableTask = BaseSet.GetTable(tableName);
		string modPath = GetPathFor(tableName);
		if(File.Exists(modPath))
		{
			table = TableModLoader.Load(modPath, baseTableTask);
		}
		else
		{
			table = new DataTable(baseTableTask);
		}
		table.TableName = tableName;
		tableMods.Add(tableName, table);
		return table;
	}

	public string GetPathFor(GameTableName tableName)
	{
		return Path.Combine(Project.FileSystem.projectFilesPath, GameTableUtil.GetDefaultFilePath(tableName) + "mod");
	}

	public void SaveMods()
	{
		foreach(var mod in tableMods)
		{
			TableModLoader.Write(mod.Value, GetPathFor(mod.Key));
		}
	}

	public string[] ExportMods(string dest)
	{
		var tables = Enum.GetValues<GameTableName>();
		List<string> result = new();

		foreach (var tableName in tables)
		{
			try
			{
				string srcPath = GetPathFor(tableName);
				if (File.Exists(srcPath))
				{
					string dstPath = Path.Combine(Project.FileSystem.processedFilesPath, GameTableUtil.GetDefaultFilePath(tableName));
					DataTable table = GetTable(tableName);
					GameTableLoader.Save(table, dstPath);
					result.Add(dstPath);
				}
			}
			catch (Exception ex)
			{

			}
		}
		return result.ToArray();
	}

	public void ImportModsFromTbl(string src)
	{
		var tables = Enum.GetValues<GameTableName>();
		var searchPaths = new List<string> { "", "../" };
		foreach (var tableName in tables)
		{
			try
			{
				string relativePath = GameTableUtil.GetDefaultFilePath(tableName);
				string foundPath = searchPaths.Select(sp => $"{src}/{sp}{relativePath}").Where(f => File.Exists(f)).FirstOrDefault(string.Empty);
				if (String.IsNullOrWhiteSpace(foundPath)) continue;
				foundPath = Path.GetFullPath(foundPath);

				bool localization = GameTableUtil.IsLocalization(tableName);
				DataTable newTable = null;
				if (localization)
				{
					newTable = TextTableLoader.Load(foundPath);
				}
				else
				{
					newTable = GameTableLoader.Load(foundPath);
				}

				var rows = newTable.GetRowList().ToList();
				var tblmod = GetTable(tableName);
				tblmod.rows.Clear(); // just wipe it, we can't merge yet.

				foreach (var row in newTable.rows)
				{
					tblmod.InsertCopyIfDifferent(row.Key, row.Value);
				}
			}
			catch (Exception ex)
			{

			}
		}

		SaveMods();
	}
}