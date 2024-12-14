using Godot;
using System;

public enum FileType
{
    Directory,
    Image,
    Table,
    UnknownFile
}

public partial class FileEntry : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	public void SetData(string fileName, FileType fileType, Action action)
	{
		if (fileType == FileType.Directory)
		{
			Text = "Dir: " + fileName;
		}
		else
		{
            Text = fileName;
        }
		if (action != null)
		{
			Connect("pressed", Callable.From(action));
		}
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
