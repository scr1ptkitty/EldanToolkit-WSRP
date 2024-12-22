using Godot;
using System.IO;

namespace EldanToolkit.Project
{
    public partial class Project : Node
    {
        public ProjectFileSystem FileSystem {  get; private set; }
        public TableManager TableManager { get; private set; }
        public LogSystem LogSystem { get; private set; }

        public string ProjectPath { get; private set; }

        public string ProjectFilePath
        {
            get => Path.Join(ProjectPath, "Project.xml");
        }

        private Project()
		{
			FileSystem = new ProjectFileSystem(this);
			TableManager = new TableManager(this);
			LogSystem = new LogSystem(this);
        }

        public void Save()
        {
        }

        public static Project NewProject(string path)
        {
            Project proj = new Project();
            if (proj._NewProject(path))
            {
                return proj;
            }
            return null;
        }

        private bool _NewProject(string path)
        {
            ProjectPath = path;

            FileSystem.projectPath = path;
            FileSystem.MakeFolders();

            Save();
            return true;
        }

        public static Project LoadProject(string path)
        {
            Project proj = new Project();
            if (proj._LoadProject(path))
            {
                return proj;
            }
            return null;
        }

        private bool _LoadProject(string path)
        {
            ProjectPath = path;

            if (!File.Exists(ProjectFilePath))
                return false;

            FileSystem.projectPath = path;
			FileSystem.MakeFolders();

			return true;
        }

        public void ConvertFiles()
        {
            FileSystem.ConvertFiles();
        }

        public void ConvertAndCompile()
        {
            FileSystem.CompileProject();
        }
    }
}
