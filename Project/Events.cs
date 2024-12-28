using System;

namespace EldanToolkit.Project
{
    public static class Events
    {
        public delegate void ProjectLoadedEventHandler(Project project);
		public static ProjectLoadedEventHandler ProjectLoaded;

        public delegate void RecentProjectsUpdatedEventHandler();
        public static RecentProjectsUpdatedEventHandler RecentProjectsUpdated;

	}
}
