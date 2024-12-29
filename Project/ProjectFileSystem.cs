using Godot;
using LibNexus.Core;
using LibNexus.Files;
using LibNexus.Files.ModelFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EldanToolkit.Project
{
    public class ProjectFileSystem
	{
		public Project CurrentProject { get; private set; }
		
        [Export(PropertyHint.GlobalDir)]
        public string projectPath;

        public string projectFilesPath { get { return Path.Combine(projectPath, "ProjectFiles"); } }
		public string processedFilesPath { get { return Path.Combine(projectPath, "ProcessedFiles"); } }
		public string clientPatchPath { get { return Path.Combine(projectPath, "ClientPatch"); } }
        public string launcherPatchPath { get { return Path.Combine(projectPath, "LauncherPatch"); } }
		public string originalFilesPath { get { return Path.Combine(projectPath, "OriginalFiles"); } }
		public string fileCachePath { get { return Path.Combine(projectPath, "FileCache"); } }

		public ProjectFileSystem(Project proj)
		{
			CurrentProject = proj;
            ProgramSettings.ProgramSettingsUpdated += ReadArchive;
            ReadArchive();
			ProjectHolder.ProjectObservable.Subscribe((proj) => CurrentProject = proj);
		}

		public void MakeFolders()
        {
            Directory.CreateDirectory(projectFilesPath);
			Directory.CreateDirectory(originalFilesPath);
			Directory.CreateDirectory(fileCachePath);
		}

        public string ArchivePath
        {
            get
            {
                return ProgramSettings.ArchivePath;
            }
        }

        private List<ArchiveFilePair> archiveFiles = new List<ArchiveFilePair>();
        CancellationTokenSource cts = new CancellationTokenSource();

		private void ReadArchive()
        {
            archiveFiles.Clear();
            if(ArchivePath == null) { return; }
            archiveFiles.Add(new ArchiveFilePair(Path.Combine(ArchivePath, "ClientData"), true, cts.Token));
            archiveFiles.Add(new ArchiveFilePair(Path.Combine(ArchivePath, "ClientDataEN"), true, cts.Token));
			//archiveFiles.Add(new ArchiveFilePair(Path.Combine(ArchivePath, "Patch"), false, cts.Token)); // Tells the client which index files to use
			//archiveFiles.Add(new ArchiveFilePair(Path.Combine(ArchivePath, "Client64"), false, cts.Token));
			//archiveFiles.Add(new ArchiveFilePair(Path.Combine(ArchivePath, "../Bootstrap/Bootstrap"), false, cts.Token));
			//archiveFiles.Add(new ArchiveFilePair(Path.Combine(ArchivePath, "../Bootstrap/Launcher"), false, cts.Token));
			//archiveFiles.Add(new ArchiveFilePair(Path.Combine(ArchivePath, "../Bootstrap/LauncherData"), true, cts.Token)); // Actual launcher files: CSS, HTML, etc.
		}

		public SortedSet<string> GetFilesInFolder(string path)
        {
            SortedSet<string> files = new SortedSet<string>();
            if (projectFilesPath != null)
            {
                string fullPath = Path.Combine(projectFilesPath, path);
                if (Directory.Exists(fullPath))
                {
                    files.UnionWith(Directory.GetFiles(Path.Combine(projectFilesPath, path)).Select((p) => Path.GetFileName(p)));
                }
            }
            foreach(var a in archiveFiles)
            {
                if (a.IsReady())
                {
                    files.UnionWith(a.GetFileSystem().ListFiles(path));
                }
            }
            return files;
        }

        public SortedSet<string> GetFoldersInFolder(string path)
        {
            SortedSet<string> folders = new SortedSet<string>();
            if (projectFilesPath != null)
            {
                string fullPath = Path.Combine(projectFilesPath, path);
                if (Directory.Exists(fullPath))
                {
                    folders.UnionWith(Directory.GetDirectories(Path.Combine(projectFilesPath, path)).Select((p) => Path.GetFileName(p)));
                }
            }
            foreach (var a in archiveFiles)
            {
                if (a.IsReady())
                {
                    folders.UnionWith(a.GetFileSystem().ListDirectories(path));
                }
            }
            return folders;
        }

        public bool IsInProject(string path)
        {
            return Path.Exists(Path.Combine(projectFilesPath, path));
        }

        public bool IsInArchive(string path, bool forceLoad = true)
        {
            foreach(var a in archiveFiles)
            {
                if((forceLoad || a.IsReady()) && a.GetFileSystem().GetFile(path) != null)
                {
                    return true;
                }
            }
            return false;
        }

        public byte[] GetFileFromArchive(string path)
        {
			foreach (var a in archiveFiles)
			{
				byte[] file = a.GetFileSystem().Read(path);
				if (file != null)
				{
					return file;
				}
			}
			return null;
		}

        public bool ExtractFileToLocation(string path, string newPath)
        {
			var file = GetFileFromArchive(path);
			if (file != null)
			{
				string dir = Path.GetDirectoryName(path);
				Directory.CreateDirectory(Path.GetDirectoryName(newPath));
				FileStream fs = new FileStream(newPath, FileMode.CreateNew, System.IO.FileAccess.Write);
				fs.Write(file);
				fs.Flush();
				fs.Dispose();
                Events.FileSystemChanged?.Invoke();
				return true;
			}
			return false;
		}

        public string ExtractToTemp(string path)
        {
            string tempFile = Path.GetTempFileName();

            if (ExtractFileToLocation(path, tempFile)) return tempFile;

            return null;
        }

        public bool AddtoProject(string path)
        {
            return ExtractFileToLocation(path, Path.Combine(projectFilesPath, Path.GetDirectoryName(path)));
        }

        public void RemoveFromProject(string path)
        {
            File.Delete(Path.Combine(projectFilesPath, path));
            Events.FileSystemChanged?.Invoke();
        }

        public void ConvertFiles()
        {
            var files = GetAllProjectFiles(projectFilesPath);
			var importfiles = files.Where(f => Path.GetExtension(f).ToLowerInvariant() == ".import");
            GD.Print(".import files:");
            GD.Print(importfiles.ToArray().Join(",\n"));
            
            foreach(var f in importfiles)
            {
                string relative = Path.GetRelativePath(projectFilesPath, f).GetBaseName();
                ImportFile.Load(f).Import(Path.Combine(processedFilesPath, relative), false, CurrentProject);
            }
		}

        public void CompileProject()
		{
			Directory.CreateDirectory(clientPatchPath); // Make sure this folder exists
			Directory.CreateDirectory(processedFilesPath);

            var files = Directory.EnumerateFiles(projectFilesPath, "*.import", SearchOption.AllDirectories).Select(f => (f, ImportFile.Load(f))).ToArray();

            string[] archives = {
                "Client64",
                "ClientData",
                "ClientDataDE",
                "ClientDataEN",
                "ClientDataFR"
            };

            var archivePaths = archives.Select(file => (file, dest: Path.Combine(clientPatchPath, file + ".index"), src: Path.Combine(originalFilesPath, file + ".index"))).ToArray();
            archivePaths = archivePaths.Where(f => File.Exists(f.src)).ToArray();

            foreach (var archive in archivePaths)
            {
                if (File.Exists(archive.src))
				{
                    var subset = files.Where(f => string.Equals(f.Item2.targetArchive.ToString(), archive.file, StringComparison.InvariantCultureIgnoreCase)).ToArray();
					CompileArchive(subset, archive.src, archive.dest);
                }
            }

            IndexToolWrapper.DoCompile(clientPatchPath, archivePaths.Select(f => f.file + ".index"), Path.Combine(originalFilesPath, "Patch.index"), Path.Combine(clientPatchPath, "Patch.index"));
		}

        public void CompileArchive(IEnumerable<(string, ImportFile)> files, string inputIndex, string outputIndex)
		{
			File.Copy(inputIndex, outputIndex, true);

			if (!files.Any()) return;
			var pathFixed = files.Select(f => (Path.Combine(processedFilesPath, Path.GetRelativePath(projectFilesPath, f.Item1.GetBaseName())), f.Item2)).ToArray();

			var converted = pathFixed.SelectMany(f => f.Item2.Import(f.Item1, false, CurrentProject)).ToArray();
            IndexToolWrapper.DoCompile(processedFilesPath, converted.Select(f => Path.GetRelativePath(processedFilesPath, f)), inputIndex, outputIndex);
        }

        public List<string> GetAllProjectFiles(string path)
        {
            List<string> files = new List<string>();
            foreach(var dir in Directory.EnumerateDirectories(path))
            {
                files.AddRange(GetAllProjectFiles(dir));
            }
            files.AddRange(Directory.EnumerateFiles(path));
            return files;
        }

        public void LoadModel(string path)
        {
            Stream stream = File.OpenRead(Path.Combine(projectFilesPath, path));
            Model mdl = new Model(stream);
        }
    }
    public class ArchiveFilePair
    {
        FileSystem fs = null;
        Task<FileSystem> task = null;
        Progress progress;

        public ArchiveFilePair(string index, bool hasArchive, CancellationToken token)
        {
            progress = new Progress();
            task = Task.Run(() => FileSystem.Create(progress, index, hasArchive, null, token));
            task.ContinueWith((t) =>
            {
                Callable.From(() => Events.FileSystemChanged?.Invoke()).CallDeferred();
            });
        }

        public FileSystem GetFileSystem()
        {
            if (fs == null && task != null)
            {
                fs = task.Result;
                task = null;
            }
            return fs;
        }

        public bool IsReady()
        {
            return task == null || task.IsCompleted;
        }
    }
}
