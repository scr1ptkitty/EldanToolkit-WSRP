using System;

namespace EldanToolkit.Project
{
    public static class Events
    {
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public static event EventHandler? eProjectLoaded;
        public static void ProjectLoaded() { eProjectLoaded?.Invoke(null, EventArgs.Empty); }

        public static event EventHandler? eRecentProjectsUpdated;
        public static void RecentProjectsUpdated() { eRecentProjectsUpdated?.Invoke(null, EventArgs.Empty); }
    }
}
