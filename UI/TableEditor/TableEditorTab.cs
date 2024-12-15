using Godot;
using System;
using System.Collections.Generic;

public partial class TableEditorTab : VBoxContainer
{
	private Stack<TableViewReference> Breadcrumbs = new();
	private Container BreadcrumbsHolder;
	private OptionButton TableSelector;

	private TableViewReference CurrentTable;

	public override void _Ready()
	{
		base._Ready();
		BreadcrumbsHolder = GetNode<Container>("%Breadcrumbs");
		TableSelector = GetNode<OptionButton>("%TableSelector");

		UpdateBreadcrumbs();
		UpdateOptionsButton();
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

	public void UpdateOptionsButton()
	{
		TableSelector.Clear();
		foreach(var c in TableViewReference.TableList)
		{
			TableSelector.AddItem(c.Name);
		}
	}

	public void GotoTable(TableViewReference table, bool wipeCrumbs)
	{
		if(wipeCrumbs)
		{
			Breadcrumbs.Clear();
		}
		Breadcrumbs.Push(table);
		CurrentTable = table;
	}
}
