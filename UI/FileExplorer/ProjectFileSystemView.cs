using EldanToolkit.Project;
using Godot;
using System;
using System.IO;

public partial class ProjectFileSystemView : Control
{
	public Project CurrentProject { get; private set; }

	[Export]
	public VBoxContainer fileList;

	[Export]
	public PackedScene fileEntryScene;

	public delegate void SelectedFileChangedEventHandler(string filename, string folder, string importFile);
    public SelectedFileChangedEventHandler SelectedFileChanged;

	public string selectedFile = null;
    public string selectedImportFile = null;

	public string selectedFilePath { get { return selectedFile == null ? null : $"{currentFolder}{selectedFile}"; } }

	protected string currentFolder = ""; // in the format "abc/def/"

	private bool needsRefresh = false;

    private Color FileInProjectColor = new Color(0.5f, 0.7f, 0.6f);
    private Color DefaultFileColor = new Color(0.5f, 0.5f, 0.5f);

	private Callable ProjectLoadEvent;

	private ProjectFileSystem pfs { get { return CurrentProject?.FileSystem; } }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
		ProjectHolder.ProjectObservable.Subscribe(ProjectLoaded);
		Events.FileSystemLoaded += Refresh;
		Refresh();
    }

	public void populate()
    {
		if (pfs == null) { return; }

		foreach(var child in fileList.GetChildren())
		{
			child.QueueFree();
            fileList.RemoveChild(child);
		}

		if (currentFolder != "")
		{
			FileEntry fe = fileEntryScene.Instantiate<FileEntry>();
			fe.SetData("<==", FileType.Directory, () => SetFolder(GetParentFolder(currentFolder)));
			fileList.AddChild(fe);
		}

        var list = pfs.GetFoldersInFolder(currentFolder);
        foreach (var file in list)
        {
			string fileName = Path.GetFileName(file);
            FileEntry fe = fileEntryScene.Instantiate<FileEntry>();
            fe.SetData(fileName, FileType.Directory, () => SetFolder($"{currentFolder}{fileName}/"));
            fileList.AddChild(fe);
        }

        list = pfs.GetFilesInFolder(currentFolder);
        foreach (var file in list)
        {
            string fileName = Path.GetFileName(file);
            FileEntry fe = fileEntryScene.Instantiate<FileEntry>();
			fe.SetData(fileName, GetFileType(file), () => SetFile(fileName));
			fe.AddThemeColorOverride("font_color", pfs.IsInProject($"{currentFolder}{fileName}") ? FileInProjectColor : DefaultFileColor);
            fileList.AddChild(fe);
        }

		needsRefresh = false;
    }

	public FileType GetFileType(string fileName)
	{
		string extension = Path.GetExtension(fileName).ToLower();
		switch(extension)
		{
			case "tex":
				return FileType.Image;
			case "tbl":
				return FileType.Table;
		}
		return FileType.UnknownFile;
	}

	protected string GetParentFolder(string path)
	{
		int pos = path.Replace('\\', '/').RFind("/", path.Length - 2);
		if(pos > 0)
		{
			return path.Substring(0, pos + 1);
		}
		return "";
	}

	protected void SetFolder(string folder)
	{
		currentFolder = folder;
		SetFile(null);
        Refresh();
	}

	protected void SetFile(string filename)
    {
        selectedFile = filename;
        if (filename == null)
        {
            selectedImportFile = null;
            return;
        }
        if (Path.GetExtension(filename).Equals(".import", System.StringComparison.InvariantCultureIgnoreCase))
        {
            selectedImportFile = filename;
        }
        else
        {
            if(File.Exists(selectedFilePath + ".import"))
            {
                selectedImportFile = filename + ".import";
            }
            else
            {
                selectedImportFile = null;
            }
        }
        SelectedFileChanged?.Invoke(filename, currentFolder, selectedImportFile);
	}
	
	public void ProjectLoaded(Project project)
	{
		CurrentProject = project;
	}

	public void Refresh()
	{
		if (!needsRefresh)
		{
			Callable.From(populate).CallDeferred();
			needsRefresh = true;
		}
	}
}
