using EldanToolkit.Shared;
using System;
using System.Collections.Generic;

public class TableViewReference
{
	public string Name { get; private set; }

	public enum TableViewType
	{
		GameTable,
		Localization,
		CustomView
	}

	public TableViewType Type { get; private set; }



	private static List<TableViewReference> Tables = MakeReferenceList();

	private static List<TableViewReference> MakeReferenceList()
	{
		List<TableViewReference> list = new();
		foreach(var e in Enum.GetNames(typeof(GameTableName)))
		{
			list.Add(new TableViewReference()
			{
				Name = e,
				Type = TableViewType.GameTable
			});
		}

		list.Add(new TableViewReference()
		{
			Name = "Localization",
			Type = TableViewType.Localization
		});
		return list;
	}

	public static IEnumerable<TableViewReference> TableList => Tables.AsReadOnly();
}