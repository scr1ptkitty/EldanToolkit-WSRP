using EldanToolkit.Project;
using EldanToolkit.Shared;
using Godot;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WildStar.TestBed;

public partial class TableEditorTab : VBoxContainer
{
	public Project Project { get; private set; }
	private Stack<TableViewReference> Breadcrumbs = new();
	private Container BreadcrumbsHolder;
	private OptionButton TableSelector;
	private Dictionary<int, TableViewReference> TableSelectorLookup = new();
	private Container EntryEditor;
	private EntryListElement TableEntryList;
	private Button SaveButton;
	private Button ImportTblButton;

	private TableViewReference CurrentTable;
	private DataTable TableRef;
	private int? CurrentEntryID = null;

	[Export]
	public PackedScene EntryCell;

	public override void _Ready()
	{
		base._Ready();

		BreadcrumbsHolder = GetNode<Container>("%Breadcrumbs");
		TableSelector = GetNode<OptionButton>("%TableSelector");
		TableSelector.ItemSelected += TableSelected;

		EntryEditor = GetNode<Container>("%EntryEditor");
		TableEntryList = GetNode<EntryListElement>("%EntryList");
		TableEntryList.SelectionChanged += SelectEntry;

		SaveButton = GetNode<Button>("%SaveButton");
		SaveButton.Pressed += SaveTables;

		ImportTblButton = GetNode<Button>("%ImportTblButton");
		ImportTblButton.Pressed += SelectTblImportFolder;

		UpdateBreadcrumbs();
		UpdateTableSelector();

		ProjectHolder.ProjectObservable.Subscribe(ProjectChanged);
	}

	public void ProjectChanged(Project project)
	{
		Project = project;

		UpdateBreadcrumbs();
		UpdateTableSelector();
	}

	public void UpdateBreadcrumbs()
	{
		foreach(var c in BreadcrumbsHolder.GetChildren())
		{
			BreadcrumbsHolder.RemoveChild(c);
			c.QueueFree();
		}
		foreach(var c in Breadcrumbs)
		{
			Button button = new Button();
			button.Text = c.Name;
			BreadcrumbsHolder.AddChild(button);
		}
	}

	public void UpdateTableSelector()
	{
		TableSelector.Clear();
		TableSelectorLookup.Clear();
		int i = 0;
		foreach(var c in TableViewReference.TableList)
		{
			TableSelector.AddItem(c.Name, i);
			TableSelectorLookup[i] = c;
			i++;
		}
	}

	private void TableSelected(long index)
	{
		if (TableSelectorLookup.TryGetValue((int) index, out var table))
		{
			GotoTable(table, true, null);
		}
	}

	public void GotoTable(TableViewReference table, bool wipeCrumbs, int? entryID)
	{
		if(wipeCrumbs)
		{
			Breadcrumbs.Clear();
		}
		Breadcrumbs.Push(table);
		UpdateBreadcrumbs();

		SetTable(table);
	}

	private void SetTable(TableViewReference table)
	{
		CurrentTable = table;
		if (table.Type == TableViewReference.TableViewType.CustomView) return;

		TableRef = Project.TableMods.GetTable(table.NameEnum);

		TableEntryList.DataSet = Project.TableMods;
		TableEntryList.TableName = table.NameEnum;
		UpdateListCache();
		TableEntryList.GotoPage(0, true);
	}

	private void UpdateListCache()
	{
		TableEntryList.OrderedList = TableRef.GetRowList().OrderBy(r => r.Key).ToList(); // Good place to add any filters.
	}

	public void SelectEntry(uint? id)
	{
		if (id == CurrentEntryID) return;

		// Clear
		foreach (var child in EntryEditor.GetChildren())
		{
			child.QueueFree();
			EntryEditor.RemoveChild(child);
		}

		if (id == null || TableRef == null) return;

		TableStructure structure = TableStructure.GetStructure(TableRef.TableName);

		DataRow row = TableRef.GetRow(id.Value);

		foreach(var column in TableRef.schema)
		{
			if (column.Key == "UID") continue;
			EntryEditor.AddChild(CreateVariableCell(id.Value, Project.TableMods, CurrentTable.NameEnum, column.Key));
		}
	}

	private Control CreateVariableCell(uint id, TableDataSet set, GameTableName tableName, string column)
	{
		TableCell cell = EntryCell.Instantiate<TableCell>();
		cell.SetValues(id, set, tableName, column);
		return cell;
	}

	public void SaveTables()
	{
		Project.TableMods.SaveMods();
	}

	public void SelectTblImportFolder()
	{
		FileDialog fd = new FileDialog();
		fd.FileMode = FileDialog.FileModeEnum.OpenDir;
		fd.Access = FileDialog.AccessEnum.Filesystem;
		fd.UseNativeDialog = true;
		fd.Show();
		string path = fd.CurrentFile;

		if (path == null) return;

		Project.TableMods.ImportModsFromTbl(path);
	}
}
