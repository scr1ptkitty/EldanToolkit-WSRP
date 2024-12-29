using Godot;

public partial class ImportFileEditor : Control
{
	private Control ImportFileBroken = null;
	private Control ImportFileGeneral = null;
	private Label ImportFileType = null;

	private ImportFile importFile = null;

	public override void _Ready()
	{
		SetupButtons();
	}

	private void SetupButtons()
	{
		ImportFileBroken = GetNode<Control>("%ImportFileBroken");
		ImportFileGeneral = GetNode<Control>("%ImportFileGeneral");
		ImportFileType = GetNode<Label>("%ImportFileType");
	}

	public void RefreshImportFileEditor(string path)
	{
		importFile = ImportFile.Load(path);
		ImportFileBroken.Visible = (importFile == null);
		ImportFileGeneral.Visible = !ImportFileBroken.Visible;
		if (ImportFileBroken.Visible) return; // Yup. Dunno what to do.

		ImportFileType.Text = "Import type: " + importFile.type.ToString();
	}
}