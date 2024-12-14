using System;

namespace LibNexus.Files.IndexFiles;

[Flags]
public enum IndexFileFlags : uint
{
	Complete = 1,
	Compressed = 4
}
