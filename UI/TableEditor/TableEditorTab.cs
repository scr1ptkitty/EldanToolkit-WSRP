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

	[Export]
	public PackedScene EntryListButton;

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

		var task = ProjectHolder.project.TableManager.GetTableAsync(table.NameEnum);
		TableRef = task.Result;

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
			
			EntryList.AddChild(entryButton);
		}
	}

	private void UpdateListCache()
	{
		OrderedList = TableRef.GetRowList().OrderBy(r => r.Key).ToList(); // Good place to add any filters.
	}

	public void SelectEntry(int? id)
	{
		if (id == CurrentEntryID) return;

	}
}
