## Building from source

Should be super simple. First, download/install this stuff...

1. Install Godot 4.3 (with Mono): https://godotengine.org/download/windows/ (pick "Godot Engine - .net")
    - Recommend creating a shortcut to `Godot_v4.3-stable_mono_win64.exe` on your desktop for convenience.
2. Install the .net SDK 8.0.x. We will use this to build the source code in Visual Studio: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
3. Install Visual Studio (I use Visual Studio 2022 Community Edition): https://visualstudio.microsoft.com/vs/community/. Other IDEs should work too, but debugging Godot projects might involve steps I don't know of. 
4. Get the source code onto your computer. If you plan to submit code changes, you should do this by forking and cloning the Git repo.

Once everything is installed, you need to import, build and run the project:

5. Run Godot from `Godot_v4.3-stable_mono_win64.exe`. Click `Import`, then select the EldanToolkit source folder and open that as a Godot project.
6. Run Visual Studio 2022. Select `Open a project or solution`, browse to your EldanToolkit source folder, and open `EldanToolkit.sln` as a Visual Studio project.
7. Build the solution in Visual Studio using `Build` -> `Build Solution`.
    - If VS complains about not being able to target SDK 8.0, make sure you downloaded and installed the most up-to-date version of VS 2022.
    - If VS is still not happy, go to `Tools` -> `Get Tools and Features...` then click `Modify` on your existing installation (one of the tiles in the middle of that window that pops up), go to the `Individual components` tab, and find the .net 8.0 runtime (long term support).
8. After the code has been built, launch debug mode from Visual Studio. This will run the Godot project.
    - If VS pops up an error about the executable path, go to `Debug` -> `EldanToolkit Debug Properties` and change the Executable path to match the file path of your Godot exe (`Godot_v4.3-stable_mono_win64.exe`).
    - Please make sure not to include this change (one of the project files) when you submit PRs. Keeps things clean, and such.