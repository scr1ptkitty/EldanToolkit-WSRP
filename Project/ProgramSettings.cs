using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Xml;
using System.Xml.Serialization;

namespace EldanToolkit.Project
{
    [XmlRoot("ProgramSettings")]
    public class ProgramSettingsFile
    {
        [XmlArray("LastProjects")]
        [XmlArrayItem("Project")]
        public List<string> lastProjects { get; set; } = new List<string>();

        [XmlAttribute("ArchivePath")]
        public string archivePath { get; set; }
		[XmlAttribute("NexusVaultPath")]
		public string nexusVaultPath { get; set; }
		[XmlAttribute("IndexToolPath")]
		public string indexToolPath { get; set; }
	}

    public static class ProgramSettings
	{
		public static string ArchivePath { get { return file.archivePath; } set { file.archivePath = value; _archivePathSubject.OnNext(value); QueueSave(); } }
		private static readonly BehaviorSubject<string> _archivePathSubject = new BehaviorSubject<string>(null);
        public static IObservable<string> ArchivePathObservable => _archivePathSubject.AsObservable().Throttle(TimeSpan.FromMilliseconds(500)).DistinctUntilChanged();

		public static string NexusVaultPath { get { return file.nexusVaultPath; } set { file.nexusVaultPath = value; QueueSave(); } }

		public static string IndexToolPath { get { return file.indexToolPath; } set { file.indexToolPath = value; QueueSave(); } }

		private static ProgramSettingsFile file;

        public static void NoteProjectLoaded(string path)
        {
			file.lastProjects.Remove(path);
			file.lastProjects.Insert(0, path);
            if (file.lastProjects.Count > 10)
            {
				file.lastProjects.Remove(file.lastProjects.Last());
            }
			QueueSave();
            Events.RecentProjectsUpdated();
        }

        public static IReadOnlyList<string> getLastProjects()
        {
            return file.lastProjects.AsReadOnly();
        }

        public static string GetLastProject()
        {
            if(file.lastProjects.Count == 0)
            {
                return null;
            }
            return file.lastProjects[0];
        }

        private static string appDataPath { get => Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EldanToolkit"); }
        private static string appSettingsPath { get => Path.Join(appDataPath, "AppSettings.xml"); }

        private static bool dirty = false;

        private static void Save()
        {
            if (!dirty) return;

            if (!Directory.Exists(appDataPath))
                Directory.CreateDirectory(appDataPath);

			XmlWriterSettings settings = new XmlWriterSettings { Indent = true };
			using var writer = XmlWriter.Create(appSettingsPath, settings);
			XmlSerializer serializer = new XmlSerializer(typeof(ProgramSettingsFile));
			serializer.Serialize(writer, file);
            dirty = false;
        }

        private static void QueueSave()
        {
            dirty = true;
			Godot.Callable.From(Save).CallDeferred();
        }

        public static void Load()
        {
            if (!File.Exists(appSettingsPath))
            {
                file = new ProgramSettingsFile();
				return;
			}

            try
            {
                using var reader = XmlReader.Create(appSettingsPath);
                XmlSerializer serializer = new XmlSerializer(typeof(ProgramSettingsFile));
                file = (ProgramSettingsFile)serializer.Deserialize(reader);

                ArchivePath = ArchivePath; // Just to trigger the observable.
            }
            catch (Exception)
			{
                Godot.GD.Print("Could not load program settings.");
                file = new ProgramSettingsFile();
            }
        }
    }
}
