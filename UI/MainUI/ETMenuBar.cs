using Godot;
using System.Collections.Generic;
using System;
using EldanToolkit.Project;

public partial class ETMenuBar : MenuBar
{
	[Export]
	public PackedScene ProjectSettingsUIScene;

	private MainTabs tabs;

	private PopupMenu FileMenu;
	private List<Action> FileMenuCallbacks;
	private PopupMenu RecentProjects;
	private PopupMenu BuildMenu;
	private List<Action> BuildMenuCallbacks;

	public void SetupMenuBar(MainTabs tabs)
	{
		this.tabs = tabs;
		FileMenu = new PopupMenu();
		FileMenuCallbacks = new();
		FileMenu.Name = "File";
		AddChild(FileMenu);
		FileMenu.Connect("index_pressed", Callable.From((int index) => {
			if (FileMenuCallbacks[index] != null)
			{
				FileMenuCallbacks[index]();
			}
		}));

		FileMenu.AddItem("New Project");
		FileMenuCallbacks.Add(() =>
		{
			FileDialog fd = new FileDialog();
			fd.FileMode = FileDialog.FileModeEnum.OpenDir;
			fd.Access = FileDialog.AccessEnum.Filesystem;
			fd.UseNativeDialog = true;
			fd.CurrentDir = ProgramSettings.GetLastProject() ?? "C:/";
			fd.Show();
			string path = fd.CurrentFile;
			if (path != null)
			{
				if (ProjectHolder.Instance.NewProject(path))
				{
					ProgramSettings.NoteProjectLoaded(path);
				}
			}
		});

		/*FileMenu.AddItem("Recent Projects");
        FileMenuCallbacks.Add(null);*/

		FileMenu.AddItem("Load Project");
		FileMenuCallbacks.Add(() =>
		{
			FileDialog fd = new FileDialog();
			fd.FileMode = FileDialog.FileModeEnum.OpenDir;
			fd.Access = FileDialog.AccessEnum.Filesystem;
			fd.UseNativeDialog = true;
			fd.CurrentDir = ProgramSettings.GetLastProject() ?? "C:/";
			fd.Show();
			string path = fd.CurrentFile;
			if (path != null)
			{
				if (ProjectHolder.Instance.LoadProject(path))
				{
					ProgramSettings.NoteProjectLoaded(path);
				}
			}
		});

		FileMenu.AddItem("Program Settings");
		FileMenuCallbacks.Add(() =>
		{
			Window settingsUI = ProjectSettingsUIScene.Instantiate<Window>();
			settingsUI.Visible = false;
			settingsUI.ForceNative = true;
			GetTree().Root.AddChild(settingsUI);
			settingsUI.Show();
		});

		/*if (FileMenu != null && RecentProjects != null)
        {
            FileMenu.SetItemSubmenuNode(RecentProjectsItemIndex, RecentProjects);
        }*/

		BuildMenu = new PopupMenu();
		BuildMenuCallbacks = new();
		BuildMenu.Name = "Build";
		AddChild(BuildMenu);
		BuildMenu.Connect("index_pressed", Callable.From((int index) => {
			if (BuildMenuCallbacks[index] != null)
			{
				BuildMenuCallbacks[index]();
			}
		}));

		BuildMenu.AddItem("Convert Files");
		BuildMenuCallbacks.Add(() =>
		{
			ProjectHolder.project.ConvertFiles();
		});

		BuildMenu.AddItem("Convert & Compile Project");
		BuildMenuCallbacks.Add(() =>
		{
			ProjectHolder.project.ConvertAndCompile();
		});
	}
}