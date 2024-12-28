using System;

namespace EldanToolkit.Project
{
    public static class Events
    {
        public delegate void FileSystemLoadedEventHandler();
		public static FileSystemLoadedEventHandler FileSystemLoaded;

        public delegate void RecentProjectsUpdatedEventHandler();
        public static RecentProjectsUpdatedEventHandler RecentProjectsUpdated;

	}
}
