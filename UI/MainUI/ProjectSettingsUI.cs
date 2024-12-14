using EldanToolkit.Project;
using Godot;
using System;

public partial class ProjectSettingsUI : Window
{
	TextEdit ArchivePathBox;
	TextEdit NexusVaultPathBox;
	TextEdit IndexToolPathBox;

	Button ArchivePathFind;
	Button NexusVaultPathFind;
	Button IndexToolPathFind;

	Button SaveButton;
	Button CancelButton;

	public override void _Ready()
	{
		base._Ready();
		ArchivePathBox = GetNode<TextEdit>("%ArchivePathBox");
		ArchivePathBox.Text = ProgramSettings.ArchivePath;
		NexusVaultPathBox = GetNode<TextEdit>("%NexusVaultPathBox");
		NexusVaultPathBox.Text = ProgramSettings.NexusVaultPath;
		IndexToolPathBox = GetNode<TextEdit>("%IndexToolPathBox");
		IndexToolPathBox.Text = ProgramSettings.IndexToolPath;

		ArchivePathFind = GetNode<Button>("%ArchivePathFind");
		ArchivePathFind.Pressed += FindArchivePath;
		NexusVaultPathFind = GetNode<Button>("%NexusVaultPathFind");
		NexusVaultPathFind.Pressed += FindNexusVaultPath;
		IndexToolPathFind = GetNode<Button>("%IndexToolPathFind");
		IndexToolPathFind.Pressed += FindIndexToolPath;

		SaveButton = GetNode<Button>("%ProjectSettingsSave");
		SaveButton.Pressed += SaveSettings;
		CancelButton = GetNode<Button>("%ProjectSettingsCancel");
		CancelButton.Pressed += CloseWindow;

		CloseRequested += CloseWindow;
	}

	public void FindArchivePath()
	{
		FileDialog fd = new FileDialog();
		fd.FileMode = FileDialog.FileModeEnum.OpenDir;
		fd.Access = FileDialog.AccessEnum.Filesystem;
		fd.UseNativeDialog = true;
		fd.CurrentDir = String.IsNullOrEmpty(ArchivePathBox.Text) ? ArchivePathBox.Text : ProgramSettings.ArchivePath ?? "C:/";
		fd.Show();
		string path = fd.CurrentFile;

		if (path != null)
		{
			ArchivePathBox.Text = path;
		}
	}

	public void FindNexusVaultPath()
	{
		FileDialog fd = new FileDialog();
		fd.FileMode = FileDialog.FileModeEnum.OpenFile;
		fd.Access = FileDialog.AccessEnum.Filesystem;
		fd.AddFilter("*.exe", "NexusVault exe");
		fd.UseNativeDialog = true;
		fd.CurrentDir = String.IsNullOrEmpty(NexusVaultPathBox.Text) ? NexusVaultPathBox.Text : ProgramSettings.NexusVaultPath ?? "C:/";
		fd.Show();
		string path = fd.CurrentFile;

		if (path != null)
		{
			NexusVaultPathBox.Text = path;
		}
	}

	public void FindIndexToolPath()
	{
		FileDialog fd = new FileDialog();
		fd.FileMode = FileDialog.FileModeEnum.OpenFile;
		fd.Access = FileDialog.AccessEnum.Filesystem;
		fd.AddFilter("*.exe", "Index tool exe");
		fd.UseNativeDialog = true;
		fd.CurrentDir = String.IsNullOrEmpty(IndexToolPathBox.Text) ? IndexToolPathBox.Text : ProgramSettings.IndexToolPath ?? "C:/";
		fd.Show();
		string path = fd.CurrentFile;

		if (path != null)
		{
			IndexToolPathBox.Text = path;
		}
	}

	private string FindPath(string defaultPath)
	{
		FileDialog fd = new FileDialog();
		fd.FileMode = FileDialog.FileModeEnum.OpenDir;
		fd.Access = FileDialog.AccessEnum.Filesystem;
		fd.UseNativeDialog = true;
		fd.CurrentDir = defaultPath;
		fd.Show();
		return fd.CurrentFile;
	}

	public void SaveSettings()
	{
		ProgramSettings.ArchivePath = ArchivePathBox.Text;
		ProgramSettings.NexusVaultPath = NexusVaultPathBox.Text;
		ProgramSettings.IndexToolPath = IndexToolPathBox.Text;
		CloseWindow();
	}

	public void CloseWindow()
	{
		QueueFree();
	}
}
