using EldanToolkit.Shared;
using Godot;
using System;
using System.Data;

public partial class TableCell : Container
{
	private Label CellName;
	private LineEdit CellLineEdit;

	public void SetValues(uint id, TableDataSet set, GameTableName tableName, string column)
	{
		CellName = GetNode<Label>("%CellName");
		CellLineEdit = GetNode<LineEdit>("%CellLineEdit");

		var table = set.GetTable(tableName);
		var row = table.GetRow(id);
		TableStructure ts = TableStructure.GetStructure(tableName);

		CellName.Text = column;

		var columnData = ts.GetColumn(column);

		if (columnData.Type == TableColumn.ColumnType.Reference)
		{

		}
		CellLineEdit.Text = row.GetValueRaw(column)?.ToString() ?? "";
		CellLineEdit.TextChanged += (newText) =>
		{
			var table = set.GetTable(tableName); // Get again, in case some tablemod was loaded or changed
			var row = table.GetRow(id);
			row.SetValue(column, newText);
		};
	}
}