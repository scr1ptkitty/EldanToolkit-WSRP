using LibNexus.Core.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LibNexus.Core;

public class DirectoryCopier
{
	private const int MegaByte = 1024 * 1024;

	private readonly Dictionary<string, string> _tasks = [];

	private ulong _totalSize;

	public void Add(string source, string target)
	{
		Measure(source);
		_tasks.Add(source, target);
	}

	private void Measure(string path)
	{
		foreach (var directory in Directory.GetDirectories(path))
			Measure(directory);

		foreach (var file in Directory.GetFiles(path))
			_totalSize += (ulong)new FileInfo(file).Length;
	}

	public async Task Run(Progress progress, CancellationToken cancellationToken)
	{
		progress.Total = _totalSize;

		progress.GetProgressLabel = static progress => string.Join(
			" / ",
			new float[] { progress.Completed, progress.Total }.Select(static value => $"{Math.Ceiling(value / MegaByte)} MB")
		);

		foreach (var (source, target) in _tasks)
		{
			progress.Title = $"Copying: {Path.GetFileName(source)}";
			await Copy(source, target, progress, cancellationToken);
		}

		progress.Title = "Copying";
	}

	private static async Task Copy(string source, string target, Progress progress, CancellationToken cancellationToken)
	{
		foreach (var sourceDirectory in Directory.GetDirectories(source))
		{
			cancellationToken.ThrowIfCancellationRequested();

			var targetDirectory = Path.Combine(target, Path.GetFileName(sourceDirectory));

			Directory.CreateDirectory(targetDirectory);
			await Copy(sourceDirectory, targetDirectory, progress, cancellationToken);
		}

		foreach (var sourceFile in Directory.GetFiles(source))
		{
			cancellationToken.ThrowIfCancellationRequested();

			progress.Title = $"Copying: {Path.GetFileName(sourceFile)}";

			var targetFile = Path.Combine(target, Path.GetFileName(sourceFile));

			await using var input = File.Open(sourceFile, FileMode.Open, FileAccess.Read);
			await using var output = File.Open(targetFile, FileMode.Create, FileAccess.Write);

			while (input.Position < input.Length)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					output.Close();
					File.Delete(targetFile);

					cancellationToken.ThrowIfCancellationRequested();
				}

				var amount = (ulong)Math.Min(MegaByte, input.Length - input.Position);
				output.WriteBytes(input.ReadBytes(amount));
				progress.Completed += amount;
			}

			File.SetCreationTimeUtc(targetFile, File.GetCreationTimeUtc(sourceFile));
			File.SetLastWriteTimeUtc(targetFile, File.GetLastWriteTimeUtc(sourceFile));
		}
	}
}
