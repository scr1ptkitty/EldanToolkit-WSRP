using EldanToolkit.Shared;
using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class EntryListElement : VBoxContainer
{
	[Export]
	public PackedScene EntryListButton;

	public List<KeyValuePair<uint, DataRow>> OrderedList = new();
	public TableDataSet DataSet;
	public GameTableName TableName;

	private (uint, uint) CurrentPage = (0, 0);
	private const int EntriesPerPage = 10;
	private Button PrevPageButton;
	private Button NextPageButton;

	private ButtonGroup buttonGroup;
	private Container EntryList;

	public delegate void SelectionChangedEvent(uint? id);
	public SelectionChangedEvent SelectionChanged;

	public override void _Ready()
	{
		base._Ready();

		PrevPageButton = GetNode<Button>("%PrevPageButton");
		PrevPageButton.Pressed += PrevPage;
		NextPageButton = GetNode<Button>("%NextPageButton");
		NextPageButton.Pressed += NextPage;

		EntryList = GetNode<Container>("%EntryList");

		buttonGroup = new ButtonGroup();
	}

	public void NextPage()
	{
		GotoPage(CurrentPage.Item2, true);
	}

	public void PrevPage()
	{
		GotoPage(CurrentPage.Item1, false);
	}

	public void GotoPage(uint id, bool forward)
	{
		foreach (var item in EntryList.GetChildren())
		{
			item.QueueFree();
			EntryList.RemoveChild(item);
		}

		var list = OrderedList.AsEnumerable();
		if (!forward)
		{
			list = list.Reverse();
		}
		var index = OrderedList.FindIndex(r => r.Key == id);
		if (index == -1)
		{
			index = 0;
		}

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


		TableStructure ts = TableStructure.GetStructure(TableName);

		foreach (var entry in entriesToShow)
		{
			Button entryButton = EntryListButton.Instantiate<Button>();
			entryButton.Text = ts.GetEntryDescriptionFormatted(entry.Value, DataSet);
			entryButton.ToggleMode = true;
			entryButton.ButtonGroup = buttonGroup;
			entryButton.Pressed += () => SelectionChanged?.Invoke(entry.Key);

			EntryList.AddChild(entryButton);
		}
	}
}
