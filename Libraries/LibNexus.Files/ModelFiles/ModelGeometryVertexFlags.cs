using System;

namespace LibNexus.Files.ModelFiles;

[Flags]
public enum ModelGeometryVertexFlags : ushort
{
	Position = 0x0001,
	Tangent = 0x0002,
	Normal = 0x0004,
	Bitangent = 0x0008,
	Bones = 0x0010,
	Unk0020 = 0x0020,
	Color1 = 0x0040,
	Color2 = 0x0080,
	Uv = 0x0100,
	Unk0200 = 0x0200,
	Unk0400 = 0x0400,
	Unk0800 = 0x0800,
	Unk1000 = 0x1000,
	Unk2000 = 0x2000,
	Unk4000 = 0x4000,
	Unk8000 = 0x8000
}
