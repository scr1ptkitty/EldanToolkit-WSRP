using EldanToolkit.Project;
using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using WildStar.TestBed;

public partial class TableEditorTab : VBoxContainer
{
	private Stack<TableViewReference> Breadcrumbs = new();
	private Container BreadcrumbsHolder;
	private OptionButton TableSelector;
	private Dictionary<int, TableViewReference> TableSelectorLookup = new();
	private Container EntryEditor;
	private Container EntryList;
	private Button PrevPageButton;
	private Button NextPageButton;

	private TableModManager mods;

	private TableViewReference CurrentTable;
	private DataTable TableRef;
	private int? CurrentEntryID = null;
	private const int EntriesPerPage = 10;

	private ButtonGroup buttonGroup;

	[Export]
	public PackedScene EntryListButton;

	[Export]
	public PackedScene EntryCell;

	private List<KeyValuePair<uint, DataRow>> OrderedList = null;

	private (uint, uint) CurrentPage = (0, 0);

	public override void _Ready()
	{
		base._Ready();
		mods = new TableModManager(ProjectHolder.project);
		BreadcrumbsHolder = GetNode<Container>("%Breadcrumbs");
		TableSelector = GetNode<OptionButton>("%TableSelector");
		TableSelector.ItemSelected += TableSelected;

		EntryEditor = GetNode<Container>("%EntryEditor");
		EntryList = GetNode<Container>("%EntryList");

		PrevPageButton = GetNode<Button>("%PrevPageButton");
		PrevPageButton.Pressed += PrevPage;
		NextPageButton = GetNode<Button>("%NextPageButton");
		NextPageButton.Pressed += NextPage;

		buttonGroup = new ButtonGroup();

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

		TableRef = mods.GetTableMod(table.NameEnum);

		GotoPage(0, true);
	}

	private void NextPage()
	{
		GotoPage(CurrentPage.Item2, true);
	}

	private void PrevPage()
	{
		GotoPage(CurrentPage.Item1, false);
	}

	private void GotoPage(uint id, bool forward)
	{
		if (TableRef == null) throw new InvalidOperationException("Table not loaded?");

		foreach (var item in EntryList.GetChildren())
		{
			item.QueueFree();
			EntryList.RemoveChild(item);
		}

		UpdateListCache();
		var list = OrderedList.AsEnumerable();
		if(!forward)
		{
			list = list.Reverse();
		}
		var index = OrderedList.FindIndex(r => r.Key == id);
		IEnumerable<KeyValuePair<uint, DataRow>> entriesToShow;
		if (forward)
		{
			entriesToShow = OrderedList.Skip(index + 1).Take(EntriesPerPage);
			int got = entriesToShow.Count();
			int missing = EntriesPerPage - got;
			if (missing > 0)
			{
				var stuffToAdd = OrderedList.SkipLast(got).TakeLast(missing);
				entriesToShow = stuffToAdd.Concat(entriesToShow);
			}
		}
		else
		{
			entriesToShow = OrderedList.Take(index).TakeLast(EntriesPerPage);
			int got = entriesToShow.Count();
			int missing = EntriesPerPage - got;
			if (missing > 0)
			{
				var stuffToAdd = OrderedList.Skip(got).Take(missing);
				entriesToShow = entriesToShow.Concat(stuffToAdd);
			}
		}

		CurrentPage = (entriesToShow.First().Key, entriesToShow.Last().Key);


		foreach (var entry in entriesToShow)
		{
			Button entryButton = EntryListButton.Instantiate<Button>();
			entryButton.Text = $"{entry.Key}";
			entryButton.ToggleMode = true;
			entryButton.ButtonGroup = buttonGroup;
			entryButton.Pressed += () => SelectEntry(entry.Key);
			
			EntryList.AddChild(entryButton);
		}
	}

	private void UpdateListCache()
	{
		OrderedList = TableRef.GetRowList().OrderBy(r => r.Key).ToList(); // Good place to add any filters.
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

		DataRow row = TableRef.GetRow(id.Value);

		foreach(var column in TableRef.schema)
		{
			if (column.Key == "UID") continue;
			Control cell = EntryCell.Instantiate<Control>();
			Label varName = cell.GetNode<Label>("%VariableName");
			varName.Text = column.Key;
			LineEdit edit = cell.GetNode<LineEdit>("%VariableEdit");
			edit.Text = row.GetValue<object>(column.Key).ToString();
			EntryEditor.AddChild(cell);
		}
	}
}
