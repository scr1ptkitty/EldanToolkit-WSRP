using Godot;
using System;
using System.Collections.Generic;

public partial class LongButtonListControl : ScrollContainer
{
	[Export] public int ButtonHeight = 40; // Height of each button
	[Export] public PackedScene ButtonTemplate; // Template for buttons (optional)

	private Control _contentContainer;
	private List<object> _data; // Use object to store arbitrary data
	private Dictionary<int, Control> _activeButtons; // Active buttons indexed by their data index
	private int _startIndex = 0; // Index of the first visible item
	private Action<Control, object, int> _buttonSetupCallback; // Callback to define button appearance and behavior

	public override void _Ready()
	{
		// Create and set up the content container
		_contentContainer = new Control();
		AddChild(_contentContainer);
		_activeButtons = new Dictionary<int, Control>();
	}

	public void LoadData(List<object> data, Action<Control, object, int> buttonSetupCallback)
	{
		_data = data;
		_buttonSetupCallback = buttonSetupCallback;

		// Calculate total container size
		_contentContainer.CustomMinimumSize = new Vector2(CustomMinimumSize.X, _data.Count * ButtonHeight);

		UpdateVisibleButtons();
	}

	public override void _Process(double delta)
	{
		// Determine the new start index based on scrolling
		int newStartIndex = Mathf.Max(0, Mathf.FloorToInt(ScrollVertical / ButtonHeight));
		if (newStartIndex != _startIndex)
		{
			_startIndex = newStartIndex;
			UpdateVisibleButtons();
		}
	}

	public override void _Notification(int what)
	{
		if (what == NotificationResized || what == NotificationSortChildren)
		{
			// Adjust visible buttons when the container is resized
			UpdateVisibleButtons();
		}
	}

	private void UpdateVisibleButtons()
	{
		if (_data == null || _buttonSetupCallback == null) return;

		// Calculate visible range
		int visibleCount = Mathf.CeilToInt(Size.Y / ButtonHeight) + 2;
		int startIndex = _startIndex;
		int endIndex = Mathf.Min(_startIndex + visibleCount, _data.Count);

		// Reuse existing buttons or create new ones for the visible range
		HashSet<int> toRemove = new HashSet<int>(_activeButtons.Keys);

		for (int i = startIndex; i < endIndex; i++)
		{
			if (_activeButtons.ContainsKey(i))
			{
				// Keep the button already on screen
				toRemove.Remove(i);
			}
			else
			{
				// Create a new button for this index
				Control button = ButtonTemplate.Instantiate<Control>();
				_contentContainer.AddChild(button);
				_activeButtons[i] = button;
				_buttonSetupCallback.Invoke(button, _data[i], i);
			}

			// Update button position and content
			Control currentButton = _activeButtons[i];
			currentButton.Visible = true;
			currentButton.Position = new Vector2(0, i * ButtonHeight);
			currentButton.Size = new Vector2(Math.Max(Size.X, currentButton.CustomMinimumSize.X), ButtonHeight);
		}

		// Remove buttons that are no longer visible
		foreach (int index in toRemove)
		{
			Control button = _activeButtons[index];
			_contentContainer.RemoveChild(button);
			button.QueueFree();
			_activeButtons.Remove(index);
		}
	}
}
