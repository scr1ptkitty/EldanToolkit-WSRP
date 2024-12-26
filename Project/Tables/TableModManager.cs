using EldanToolkit.Project;
using EldanToolkit.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WildStar.GameTable;

public class TableModManager
{
	public TableManager TableManager { get; private set; }
	public Project Project { get; private set; }
	private Dictionary<GameTableName, DataTable> tableMods = new();

	public TableModManager(Project project)
	{
		Project = project;
		TableManager = project.TableManager;
	}

	public DataTable GetTableMod(GameTableName tableName)
	{
		if(tableMods.TryGetValue(tableName, out DataTable table))
		{
			return table;
		}
		var baseTableTask = TableManager.GetTableAsync(tableName);
		string modPath = GetPathFor(tableName);
		if(File.Exists(modPath))
		{
			table = TableModLoader.Load(modPath, baseTableTask.Result);
		}
		else
		{
			table = new DataTable(baseTableTask.Result);
		}
		table.TableName = tableName;
		tableMods.Add(tableName, table);
		return table;
	}

	public string GetModPath()
	{
		return Path.Combine(Project.FileSystem.projectFilesPath, "DB/");
	}

	public string GetPathFor(GameTableName tableName)
	{
		return GetModPath() + tableName.ToString() + ".tblmod";
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
		var files = Directory.GetFiles(GetModPath(), "*.tblmod", SearchOption.TopDirectoryOnly);
		var filePaths = files.Select(f => (src: f, dest: Path.Combine(dest, Path.GetFileNameWithoutExtension(f) + ".tbl"))).ToArray();

		foreach (var file in filePaths)
		{
			GameTableName tableName = Enum.Parse<GameTableName>(Path.GetFileNameWithoutExtension(file.src));
			DataTable table = GetTableMod(tableName);

			GameTableLoader.Save(table, file.dest);
		}
		return filePaths.Select(f => f.dest).ToArray();
	}

	public void ImportModsFromTbl(string src)
	{
		var files = Directory.GetFiles(src, "*.tbl", SearchOption.TopDirectoryOnly);
		foreach(var file in files)
		{
			GameTableName tableName;
			try
			{
				tableName = Enum.Parse<GameTableName>(Path.GetFileNameWithoutExtension(file));
			}
			catch
			{
				continue; // Not currently supported.
			}
			DataTable newTable = GameTableLoader.Load(file);
			var rows = newTable.GetRowList().ToList();
			var tblmod = GetTableMod(tableName);
			tblmod.rows.Clear(); // just wipe it, we can't merge yet.

			foreach(var row in newTable.rows)
			{
				tblmod.InsertCopyIfDifferent(row.Key, row.Value);
			}
		}
		SaveMods();
	}
}