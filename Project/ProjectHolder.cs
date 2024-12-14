using Godot;

namespace EldanToolkit.Project
{
    public partial class ProjectHolder : Node
    {
        public static ProjectHolder Instance { get; private set; }

        public static Project project { get; private set; }

        [Signal]
        public delegate void FileSystemLoadEventHandler();

        public override void _Ready()
        {
            if (Instance != null)
            {
                QueueFree();
            }
            else
            {
                Instance = this;
            }

            ProgramSettings.Load();

            string LastProject = ProgramSettings.GetLastProject();
            if(LastProject != null)
            {
                LoadProject(LastProject);
            }
        }

        public bool NewProject(string path)
        {
            Project proj = Project.NewProject(path);
            if (proj != null)
            {
                if (project != null)
                {
                    RemoveChild(project);
                    project.QueueFree();
                }
                project = proj;
                AddChild(project);
                FileSystemLoadEvent();
                return true;
            }
            return false;
        }

        public bool LoadProject(string path)
        {
            Project proj = Project.LoadProject(path);
            if (proj != null)
            {
                if (project != null)
                {
                    RemoveChild(project);
                    project.QueueFree();
                }
                project = proj;
                AddChild(project);
                FileSystemLoadEvent();
                return true;
            }
            return false;
        }

        public static void FileSystemLoadEvent()
        {
            Instance.EmitSignal(SignalName.FileSystemLoad);
        }
    }
}