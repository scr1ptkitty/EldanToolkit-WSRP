using System;
using System.Collections.ObjectModel;

namespace LibNexus.Core;

public class Progress
{
	public string Title { get; set; } = string.Empty;
	public ulong Total { get; set; }
	public ulong Completed { get; set; }

	public Collection<Progress> Children { get; } = [];

	public float Value => Completed / (float)Total;

	public Func<Progress, string> GetProgressLabel { get; set; } = static progress => $"{progress.Completed} / {progress.Total}";
}
