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
		string modPath = Path.Combine(Project.FileSystem.projectPath, tableName.ToString() + ".tblmod");
		if(File.Exists(modPath))
		{
			table = TableModLoader.Load(modPath);
			table.fallbackTable = baseTableTask.Result;
		}
		else
		{
			table = new DataTable(baseTableTask.Result);
		}
		tableMods.Add(tableName, table);
		return table;
	}
}