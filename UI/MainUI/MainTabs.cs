using Godot;
using System.Collections.Generic;
using System.Linq;

public partial class MainTabs : TabBar
{
	private List<Control> tabs = new();
	private Control tabHolder;

	public void SetupTabs(Control tabHolder)
	{
		this.tabHolder = tabHolder;
		TabChanged += ChangeTab;
		TabClosePressed += CloseTab;
		
		foreach(var tab in tabHolder.GetChildren().OfType<Control>())
		{
			AddTab(tab);
		}
		ChangeTab(0);
	}

	public bool CanCloseTab(Control tab)
	{
		if (tab is ProjectFileManager || tab is TableEditorTab) return false;
		//if (tab == fileExplorerTab) return false;
		return true;
	}

	public void ChangeTab(long index)
	{
		foreach (Control child in tabHolder.GetChildren())
		{
			child.Visible = false;
		}
		Control ctrl = GetTabMetadata((int) index).As<Control>();
		if (ctrl != null)
		{
			ctrl.Visible = true;
			TabCloseDisplayPolicy = CanCloseTab(ctrl) ? TabBar.CloseButtonDisplayPolicy.ShowActiveOnly : TabBar.CloseButtonDisplayPolicy.ShowNever;
		}
	}

	public void CloseTab(long index)
	{
		Control ctrl = tabHolder.GetChild<Control>((int)index);
		if (CanCloseTab(ctrl))
		{
			tabHolder.RemoveChild(ctrl);
			tabs.Remove(ctrl);
			ctrl.QueueFree();
			RemoveTab((int)index);
		}
	}

	public void AddTab(Control tab)
	{
		if (!tabHolder.IsAncestorOf(tab))
		{
			string tabName = tab.Name;
			int i = 1;
			while(GetTabByName(tabName) != null)
			{
				i++;
				tabName = tab.Name + " " + i.ToString();
			}
			tab.Name = tabName;
			tabHolder.AddChild(tab);
		}
		AddTab(tab.Name);
		SetTabMetadata(TabCount - 1, tab);
	}

	public Control GetTabByName(string name)
	{
		foreach(Control c in tabHolder.GetChildren())
		{
			if(c.Name == name)
			{
				return c;
			}
		}
		return null;
	}
}