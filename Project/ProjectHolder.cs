using Godot;

namespace EldanToolkit.Project
{
    public partial class ProjectHolder : Node
    {
        public static ProjectHolder Instance { get; private set; }

        public static Project CurrentProject => ProjectObservable.Value;
        public static System.Reactive.Subjects.BehaviorSubject<Project> ProjectObservable = new(null);

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
                if (CurrentProject != null)
                {
                    RemoveChild(CurrentProject);
                    CurrentProject.QueueFree();
                }
                ProjectObservable.OnNext(proj);
                AddChild(CurrentProject);
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
                if (CurrentProject != null)
                {
                    RemoveChild(CurrentProject);
                    CurrentProject.QueueFree();
                }
                ProjectObservable.OnNext(proj);
                AddChild(CurrentProject);
                FileSystemLoadEvent();
                return true;
            }
            return false;
        }

        public static void FileSystemLoadEvent()
        {
            Events.ProjectLoaded?.Invoke(CurrentProject);
        }
    }
}