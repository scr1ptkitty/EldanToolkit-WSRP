using System;

namespace EldanToolkit.Project
{
    public static class Events
    {
        public delegate void FileSystemLoadedEventHandler();
		public static FileSystemLoadedEventHandler FileSystemChanged;

        public delegate void RecentProjectsUpdatedEventHandler();
        public static RecentProjectsUpdatedEventHandler RecentProjectsUpdated;

	}
}
