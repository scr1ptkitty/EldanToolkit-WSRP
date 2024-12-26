using EldanToolkit.Project;
using EldanToolkit.Shared;
using System.Collections.Generic;
using System.IO;

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

	public string GetPathFor(GameTableName tableName)
	{
		return Path.Combine(Project.FileSystem.projectFilesPath, $"DB/{tableName.ToString()}.tblmod");
	}

	public void SaveMods()
	{
		foreach(var mod in tableMods)
		{
			TableModLoader.Write(mod.Value, GetPathFor(mod.Key));
		}
	}
}