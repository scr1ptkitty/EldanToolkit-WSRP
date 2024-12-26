Building from source:
Should be super simple.
- Use Godot 4.3 (with Mono), and open the folder as a Godot project. https://godotengine.org/download/windows/, pick "Godot Engine - .net"
- Use .net SDK 8.0.x to build the source code. https://dotnet.microsoft.com/en-us/download/dotnet/8.0
- I use Visual Studio 2022 Community Edition. https://visualstudio.microsoft.com/vs/community/. Other IDEs should work too, but debugging Godot projects might involve steps I don't know of.
One fiddly thing: to debug in Visual Studio, go to the Debug menu, EldanToolkit Debug Options, and change the Executable path to match where you've got your Godot exe. Please make sure not to include this change (one of the project files) when you submit PRs. Keeps things clean, and such.
