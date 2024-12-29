using EldanToolkit.Project;
using Godot;
using System;
using System.IO;

public partial class FileContextMenu : VBoxContainer
{
	public Project CurrentProject { get; private set; }
	private ProjectFileSystem pfs { get { return CurrentProject?.FileSystem; } }

	private Control ArchivePathWarning = null;
	private Button AddToProject = null;
	private Button RemoveFromProject = null;
	private Button LoadModel = null;
	private ImportFileEditor ImportFileEditor = null;
	private string selectedFile = null;

	public override void _Ready()
	{
		ProjectHolder.ProjectObservable.Subscribe((proj) => CurrentProject = proj);

		SetupButtons();
	}

	public void SetFile(string filePath)
	{
		selectedFile = filePath;
		Refresh();
	}

	public bool ValidFileSelected()
	{
		return selectedFile != null;
	}

	public bool FileInArchive()
	{
		return selectedFile != null && pfs.IsInArchive(selectedFile, false);
	}

	public bool FileInProject()
	{
		return selectedFile != null && pfs.IsInProject(selectedFile);
	}

	public bool FileIs(string extension)
	{
		return selectedFile != null && string.Equals(Path.GetExtension(selectedFile), extension, StringComparison.InvariantCultureIgnoreCase);
	}

	public string FileAbsolutePath()
	{
		return Path.Combine(pfs.projectFilesPath, selectedFile);
	}

	private void SetupButtons()
	{
		ArchivePathWarning = GetNode<Control>("%ArchivePathWarning");
		ProgramSettings.ProgramSettingsUpdated += Refresh;

		ImportFileEditor = GetNode<ImportFileEditor>("%ImportFileEditor");

		AddToProject = GetNode<Button>("%AddToProject");
		AddToProject.Pressed += () =>
		{
			if (ValidFileSelected())
			{
				pfs?.AddtoProject(selectedFile);
			}
		};

		RemoveFromProject = GetNode<Button>("%RemoveFromProject");
		RemoveFromProject.Pressed += () =>
		{
			if (ValidFileSelected())
			{
				pfs?.RemoveFromProject(selectedFile);
			}
		};

		LoadModel = GetNode<Button>("%LoadModel");
		LoadModel.Pressed += () =>
		{
			if (ValidFileSelected())
			{
				pfs?.LoadModel(selectedFile);
			}
		};
	}

	public void Refresh()
	{
		ArchivePathWarning.Visible = ProgramSettings.ArchivePathValid();
		AddToProject.Visible = pfs != null && !FileInProject() && FileInArchive();
		RemoveFromProject.Visible = pfs != null && FileInProject() && FileInArchive(); // Only show when the file also exists in te archive.
		LoadModel.Visible = pfs != null && FileIs(".m3");

		ImportFileEditor.Visible = pfs != null && FileIs(".import");
		if (ImportFileEditor.Visible)
			ImportFileEditor.RefreshImportFileEditor(FileAbsolutePath());
	}
}
