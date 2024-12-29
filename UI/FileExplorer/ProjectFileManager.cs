using EldanToolkit.Project;
using Godot;
using System;

public partial class ProjectFileManager : Control
{
    private FileSelector FileView;
    private FileContextMenu FileMenu;

    public override void _Ready()
    {
        FileView = GetNode<FileSelector>("%FileSelector");
        FileMenu = GetNode<FileContextMenu>("%FileMenu");

        FileView.SelectedFileChanged += FileMenu.SetFile;
    }
}