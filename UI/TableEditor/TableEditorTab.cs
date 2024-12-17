using EldanToolkit.Project;
using Godot;
using System;
using System.Collections.Generic;
using WildStar.TestBed;

public partial class TableEditorTab : VBoxContainer
{
	private Stack<TableViewReference> Breadcrumbs = new();
	private Container BreadcrumbsHolder;
	private OptionButton TableSelector;
	private Dictionary<int, TableViewReference> TableSelectorLookup = new();
	private Container EntryEditor;
	private Container EntryList;

	private TableViewReference CurrentTable;
	private DataTable TableRef;
	private int? CurrentEntryID = null;
	private const int EntriesPerPage = 20;

	public override void _Ready()
	{
		base._Ready();
		BreadcrumbsHolder = GetNode<Container>("%Breadcrumbs");
		TableSelector = GetNode<OptionButton>("%TableSelector");
		TableSelector.ItemSelected += TableSelected;

		EntryEditor = GetNode<Container>("%EntryEditor");
		EntryList = GetNode<Container>("%EntryList");

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

		TableRef = ProjectHolder.project.TableManager.GetTableAsync(table.NameEnum).Result;
	}

	/*private int GotoPage(int id, bool forward)
	{
		if(TableRef == null) return -1;

		foreach (var item in EntryList.GetChildren())
		{
			item.QueueFree();
			EntryList.RemoveChild(item);
		}

		
	}*/

	public void SelectEntry(int? id)
	{
		if (id == CurrentEntryID) return;

	}
}
