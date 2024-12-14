using EldanToolkit.Project;
using Godot;
using System;
using System.Collections.Generic;

public partial class MainUI : Control
{
    private ETMenuBar menuBar;
    private MainTabs tabBar;
    private Control tabHolder;
    private Control fileExplorerTab;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        menuBar = GetNode<ETMenuBar>("%MenuBar");
		tabBar = GetNode<MainTabs>("%TabBar");
		tabHolder = GetNode<Control>("%TabHolder");

		menuBar.SetupMenuBar(tabBar);
		tabBar.SetupTabs(tabHolder);
	}

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}
}