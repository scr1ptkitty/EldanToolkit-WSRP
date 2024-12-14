using EldanToolkit.Project;
using Godot;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

public static class NexusVaultWrapper
{
	public static bool DoConvert(string file, string outputFile, params string[] options)
	{
		try
		{
			if (!string.IsNullOrEmpty(ProgramSettings.NexusVaultPath))
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo { CreateNoWindow = true, FileName = ProgramSettings.NexusVaultPath, UseShellExecute = false, RedirectStandardInput = true };
				Process proc = Process.Start(processStartInfo);

				using (StreamWriter w = proc.StandardInput)
				{
					string dir = outputFile.GetBaseDir();
					Directory.CreateDirectory(dir);

					w.WriteLine($"convert {string.Join(' ', options.Append(file))}");
					Thread.Sleep(4000);
					w.WriteLine("exit");

					if (!proc.WaitForExit(2000))
					{
						proc.Close();
						return false;
					}

					// Can't specify which folder to write to, so it's Ugly Hack time!
					string outputProbably = Path.Combine(file.GetBaseDir(), outputFile.GetFile());
					if(File.Exists(outputProbably))
					{
						if (File.Exists(outputFile))
						{
							File.Delete(outputFile);
						}

						File.Move(outputProbably, outputFile);
						return true;
					}
				}
			}
		}
		catch(Exception e)
		{
			GD.Print(e);
		}

		return false;
	}
}