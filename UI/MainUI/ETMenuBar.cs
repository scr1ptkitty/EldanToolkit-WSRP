using Godot;
using System.Collections.Generic;
using System;
using EldanToolkit.Project;

public partial class ETMenuBar : MenuBar
{
	public Project CurrentProject { get; private set; }

	[Export]
	public PackedScene ProjectSettingsUIScene;

	public MainTabs tabs;

	private PopupMenu FileMenu;
	private List<Action> FileMenuCallbacks;
	private PopupMenu RecentProjects;
	private PopupMenu BuildMenu;
	private List<Action> BuildMenuCallbacks;

	public void Setup(MainTabs tabs)
	{
		this.tabs = tabs;
		ProgramSettings.ProgramSettingsUpdated += RefreshMenuBar; // To refresh the archive path warning.
		RefreshMenuBar();
		ProjectHolder.ProjectObservable.Subscribe((proj) => CurrentProject = proj);
	}

	public void RefreshMenuBar()
	{
		if(FileMenu != null)
		{
			FileMenu.QueueFree();
			RemoveChild(FileMenu);
		}

		FileMenu = new PopupMenu();
		FileMenuCallbacks = new();
		FileMenu.Name = "File";
		AddChild(FileMenu);
		FileMenu.IndexPressed += (index) =>
		{
			if (FileMenuCallbacks[(int)index] != null)
			{
				FileMenuCallbacks[(int)index]();
			}
		};

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
        FileMenuCallbacks.Add(null);
		
		if (FileMenu != null && RecentProjects != null)
        {
            FileMenu.SetItemSubmenuNode(RecentProjectsItemIndex, RecentProjects);
        }*/

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


		if (BuildMenu != null)
		{
			BuildMenu.QueueFree();
			RemoveChild(BuildMenu);
		}

		BuildMenu = new PopupMenu();
		BuildMenuCallbacks = new();
		BuildMenu.Name = "Build";
		AddChild(BuildMenu);
		BuildMenu.IndexPressed += (index) =>
		{
			if (BuildMenuCallbacks[(int)index] != null)
			{
				BuildMenuCallbacks[(int)index]();
			}
		};
		
		BuildMenu.AddItem("Convert Files");
		BuildMenuCallbacks.Add(() =>
		{
			CurrentProject.ConvertFiles();
		});

		if (ProgramSettings.IndexToolPath != null)
		{
			BuildMenu.AddItem("Convert & Compile Project");
			BuildMenuCallbacks.Add(() =>
			{
				CurrentProject.ConvertAndCompile();
			});
		}
	}
}