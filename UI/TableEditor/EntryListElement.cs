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

	private ButtonGroup buttonGroup;
	public LongButtonListControl EntryList;

	public delegate void SelectionChangedEvent(uint? id);
	public SelectionChangedEvent SelectionChanged;

	public override void _Ready()
	{
		base._Ready();

		buttonGroup = new ButtonGroup();

		EntryList = GetNode<LongButtonListControl>("%EntryList");
	}

	public void SetList(IEnumerable<KeyValuePair<uint, DataRow>> list)
	{
		TableStructure ts = TableStructure.GetStructure(TableName);

		var objectList = list.Cast<object>().ToList();
		EntryList.LoadData(objectList, (control, entry, id) =>
		{
			var pair = (KeyValuePair<uint, DataRow>)entry;
			var button = control as Button;

			button.Text = ts.GetEntryDescriptionFormatted(pair.Value, DataSet);
			button.ToggleMode = true;
			button.ButtonGroup = buttonGroup;
			button.Pressed += () => SelectionChanged?.Invoke(pair.Key);
		});
	}
}
