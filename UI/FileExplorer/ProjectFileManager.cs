using EldanToolkit.Project;
using Godot;
using System;

public partial class ProjectFileManager : Control
{
    public Project CurrentProject { get; private set; }

    [Export]
    public ProjectFileSystemView FileView;

    [Export]
    public Container SidebarContainer;

    private Control ArchivePathWarning = null;
    private Button AddToProject = null;
    private Button RemoveFromProject = null;
    private Button LoadModel = null;

    private ProjectFileSystem pfs { get { return CurrentProject?.FileSystem; } }

    public override void _Ready()
    {
        base._Ready();
        ProjectHolder.ProjectObservable.Subscribe((proj) => CurrentProject = proj);
        FileView.SelectedFileChanged += OnSelectedFileChanged;

        ArchivePathWarning = GetNode<Control>("%ArchivePathWarning");

        AddToProject = GetNode<Button>("%AddToProject");
        AddToProject.Connect("pressed", Callable.From(() => {
            if (FileView.selectedFile != null)
            {
                pfs?.AddtoProject(FileView.selectedFilePath);
                FileView.Refresh();
            }
        }));

        RemoveFromProject = GetNode<Button>("%RemoveFromProject");
        RemoveFromProject.Connect("pressed", Callable.From(() => {
            if (FileView.selectedFile != null)
            {
                pfs?.RemoveFromProject(FileView.selectedFilePath);
                FileView.Refresh();
            }
        }));

        LoadModel = GetNode<Button>("%LoadModel");
        LoadModel.Connect("pressed", Callable.From(() => {
            if (FileView.selectedFile != null)
            {
                pfs?.LoadModel(FileView.selectedFilePath);
                FileView.Refresh();
            }
        }));
        SetButtons();
        ProgramSettings.ProgramSettingsUpdated += UpdateArchivePathWarning;
        UpdateArchivePathWarning();
    }

    public void OnSelectedFileChanged(string filename, string folder, string importFile)
    {
        SetButtons();
    }

    protected void SetButtons()
    {
        AddToProject.Visible = false;
        RemoveFromProject.Visible = false;
        LoadModel.Visible = false;

        if (FileView.selectedFile != null)
        {
            if (pfs?.IsInProject(FileView.selectedFilePath) ?? true)
            {
                RemoveFromProject.Visible = true;
                LoadModel.Visible = true;
            }
            else
            {
                AddToProject.Visible = true;
            }
        }

        UpdateArchivePathWarning();
    }

    public void UpdateArchivePathWarning()
    {
        ArchivePathWarning.Visible = ProgramSettings.ArchivePathValid();
	}
}