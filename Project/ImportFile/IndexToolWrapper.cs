using EldanToolkit.Project;
using Godot;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

public class IndexToolWrapper
{
	public static bool DoCompile(string basePath, IEnumerable<string> files, string inputIndex, string outputIndex)
	{
		Dictionary<string, IEnumerable<string>> fileList = new Dictionary<string, IEnumerable<string>> { { basePath, files } };
		return _DoCompile(fileList, outputIndex);
	}

	private static bool _DoCompile(Dictionary<string, IEnumerable<string>> fileList, string outputPath) // Dictionary of base directories, with lists of relative file paths
	{
		try
		{
			if (!string.IsNullOrEmpty(ProgramSettings.IndexToolPath))
			{
				//string xmlPath = Path.GetTempFileName(); // Creates empty temp file and gives path to it.
				string xmlPath = Path.Combine(ProjectHolder.CurrentProject.FileSystem.projectPath, Path.GetFileNameWithoutExtension(outputPath) + ".xml");
				IndexToolXML fileListXML = new IndexToolXML();

				fileListXML.folders = new ITFileFolder[fileList.Keys.Count];

				int i = 0;
				int total = 0;
				foreach (var dir in fileList)
				{
					ITFileFolder folder = new ITFileFolder();
					fileListXML.folders[i] = folder;
					i++;
					folder.basePath = dir.Key;
					folder.files = dir.Value.Select(f => new ITFile { filePath = f }).ToArray();
					total += folder.files.Length;
				}
				if(total <= 0)
				{
					return true;
				}

				fileListXML.Write(xmlPath);

				ProcessStartInfo processStartInfo = new ProcessStartInfo { CreateNoWindow = false, FileName = ProgramSettings.IndexToolPath, UseShellExecute = false };
				processStartInfo.ArgumentList.Add("-inputxml=" + xmlPath);
				processStartInfo.ArgumentList.Add("-outputfile=" + outputPath);
				Process proc = Process.Start(processStartInfo);

				if (!proc.WaitForExit(50000))
				{
					proc.Close();
					return false;
				}

				return true;
			}
		}
		catch (Exception e)
		{
			GD.Print(e);
		}

		return false;
	}
}