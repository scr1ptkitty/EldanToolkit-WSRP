using Godot;
using System;
using System.Collections.Generic;

public partial class EntryContainer : VBoxContainer
{
	private int? currentEntryId = null;
	private Stack<int> entryNavigationStack = new Stack<int>();

	public void PopulateEntry(int entryId, Dictionary<int, Dictionary<string, object>> tableData)
	{
		ClearDetails();
		currentEntryId = entryId;

		// Dynamically add fields
		foreach (var field in tableData[entryId])
		{
			if (field.Value is ReferenceField referenceField)
			{
				AddReferenceField(field.Key, referenceField.CurrentReference, referenceField.Options);
			}
			else
			{
				AddEditableField(field.Key, field.Value);
			}
		}

		AddNavigationButtons();
	}

	private void AddEditableField(string fieldName, object fieldValue)
	{
		var hbox = new HBoxContainer();

		var label = new Label();
		label.Text = fieldName;
		hbox.AddChild(label);

		var input = new LineEdit();
		input.Text = fieldValue.ToString();
		hbox.AddChild(input);

		GetNode<VBoxContainer>("%EntryFields").AddChild(hbox);
	}

	private void AddReferenceField(string fieldName, int currentReference, List<ReferenceOption> referenceOptions)
	{
		var hbox = new HBoxContainer();

		var label = new Label();
		label.Text = fieldName;
		hbox.AddChild(label);

		var dropdown = new OptionButton();
		foreach (var option in referenceOptions)
		{
			dropdown.AddItem(option.Name, option.Id);
		}
		dropdown.Selected = referenceOptions.FindIndex(o => o.Id == currentReference);
		hbox.AddChild(dropdown);

		var goToButton = new Button();
		goToButton.Text = "Go To";
		goToButton.Connect("pressed", Callable.From(() => OnGoToPressed(currentReference)));
		hbox.AddChild(goToButton);

		var copyButton = new Button();
		copyButton.Text = "Copy/Link";
		copyButton.Connect("pressed", Callable.From(() => OnCopyPressed(currentReference)));
		hbox.AddChild(copyButton);

		GetNode<VBoxContainer>("%EntryFields").AddChild(hbox);
	}

	private void AddNavigationButtons()
	{
		var hboxContainer = GetNode<HBoxContainer>("HBoxContainer");

		var backButton = new Button();
		backButton.Text = "Back";
		backButton.Connect("pressed", Callable.From(OnBackPressed));
		hboxContainer.AddChild(backButton);

		var saveButton = new Button();
		saveButton.Text = "Save";
		saveButton.Connect("pressed", Callable.From(OnSavePressed));
		hboxContainer.AddChild(saveButton);
	}

	private void OnGoToPressed(int referenceId)
	{
		/*entryNavigationStack.Push((int)currentEntryId);
		PopulateEntry(referenceId, GetTableData()); // Implement GetTableData*/
	}

	private void OnCopyPressed(int referenceId)
	{
		/*var newReferenceId = DuplicateEntry(referenceId); // Implement this
		UpdateReference((int)currentEntryId, newReferenceId); // Implement this
		PopulateEntry((int)currentEntryId, GetTableData());*/
	}

	private void OnBackPressed()
	{
		if (entryNavigationStack.Count > 0)
		{
			var previousEntryId = entryNavigationStack.Pop();
			//PopulateEntry(previousEntryId, GetTableData());
		}
	}

	private void OnSavePressed()
	{
		//SaveEntry((int)currentEntryId); // Implement SaveEntry
	}

	private void ClearDetails()
	{
		var vbox = GetNode<VBoxContainer>("%EntryFields");
		foreach (Node child in vbox.GetChildren())
		{
			vbox.RemoveChild(child);
			child.QueueFree();
		}
	}

	// Placeholder for your custom data types
	private class ReferenceField
	{
		public int CurrentReference { get; set; }
		public List<ReferenceOption> Options { get; set; }
	}

	private class ReferenceOption
	{
		public string Name { get; set; }
		public int Id { get; set; }
	}
}
