using EldanToolkit.Libraries.LibNexus.Files;
using LibNexus.Core.Extensions;
using System;
using System.IO;

namespace LibNexus.Files.ModelFiles;

public class ModelBoneAnimation
{
	public ModelBoneAnimation(Stream stream, ModelBoneHeader header)
	{
		if (header.Animation1Entries != 0)
		{
			Goto(stream, nameof(header.Animation1TimeOffset), header.Animation1TimeOffset);
			for(ulong i = 0; i < header.Animation1Entries; i++)
            {
                UInt32 data = stream.ReadUInt32(); // TODO
            }
			stream.SkipPadding(16);

            Goto(stream, nameof(header.Animation1ValueOffset), header.Animation1ValueOffset);
            for (ulong i = 0; i < header.Animation1Entries; i++)
            {
                byte[] data = stream.ReadBytes(6); // TODO
            }
            stream.SkipPadding(16);
        }

        if (header.Animation2Entries != 0)
        {
            Goto(stream, nameof(header.Animation2TimeOffset), header.Animation2TimeOffset);
            for (ulong i = 0; i < header.Animation2Entries; i++)
            {
                UInt32 data = stream.ReadUInt32(); // TODO
            }
            stream.SkipPadding(16);

            Goto(stream, nameof(header.Animation2ValueOffset), header.Animation2ValueOffset);
            for (ulong i = 0; i < header.Animation2Entries; i++)
            {
                byte[] data = stream.ReadBytes(6); // TODO
            }
            stream.SkipPadding(16);
        }

        if (header.Animation3Entries != 0)
        {
            Goto(stream, nameof(header.Animation3TimeOffset), header.Animation3TimeOffset);
            for (ulong i = 0; i < header.Animation3Entries; i++)
            {
                UInt32 data = stream.ReadUInt32(); // TODO
            }
            stream.SkipPadding(16);

            Goto(stream, nameof(header.Animation3ValueOffset), header.Animation3ValueOffset);
            for (ulong i = 0; i < header.Animation3Entries; i++)
            {
                byte[] data = stream.ReadBytes(6); // TODO
            }
            stream.SkipPadding(16);
        }

        if (header.Animation4Entries != 0)
        {
            Goto(stream, nameof(header.Animation4TimeOffset), header.Animation4TimeOffset);
            for (ulong i = 0; i < header.Animation4Entries; i++)
            {
                UInt32 data = stream.ReadUInt32(); // TODO
            }
            stream.SkipPadding(16);

            Goto(stream, nameof(header.Animation4ValueOffset), header.Animation4ValueOffset);
            for (ulong i = 0; i < header.Animation4Entries; i++)
            {
                byte[] data = stream.ReadBytes(6); // TODO
            }
            stream.SkipPadding(16);
        }

		if (header.Animation5Entries != 0)
        {
            Goto(stream, nameof(header.Animation5TimeOffset), header.Animation5TimeOffset);
            for (ulong i = 0; i < header.Animation5Entries; i++)
            {
                UInt32 data = stream.ReadUInt32(); // TODO
            }
			stream.SkipPadding(16);

            Goto(stream, nameof(header.Animation5ValueOffset), header.Animation5ValueOffset);
            for (ulong i = 0; i < header.Animation5Entries; i++)
            {
                byte[] data = stream.ReadBytes(8); // TODO
            }
			stream.SkipPadding(16);
        }

        if (header.Animation6Entries != 0)
        {
            Goto(stream, nameof(header.Animation6TimeOffset), header.Animation6TimeOffset);
            for (ulong i = 0; i < header.Animation6Entries; i++)
            {
                UInt32 data = stream.ReadUInt32(); // TODO
            }
            stream.SkipPadding(16);

            Goto(stream, nameof(header.Animation6ValueOffset), header.Animation6ValueOffset);
            for (ulong i = 0; i < header.Animation6Entries; i++)
            {
                byte[] data = stream.ReadBytes(8); // TODO
            }
            stream.SkipPadding(16);
        }

		if (header.Animation7Entries != 0)
        {
            Goto(stream, nameof(header.Animation7TimeOffset), header.Animation7TimeOffset);
            for (ulong i = 0; i < header.Animation7Entries; i++)
            {
                UInt32 data = stream.ReadUInt32(); // TODO
            }
            stream.SkipPadding(16);

            Goto(stream, nameof(header.Animation7ValueOffset), header.Animation7ValueOffset);
            for (ulong i = 0; i < header.Animation7Entries; i++)
            {
                byte[] data = stream.ReadBytes(12); // TODO
            }
            stream.SkipPadding(16);
		}

        if (header.Animation8Entries != 0)
        {
            Goto(stream, nameof(header.Animation8TimeOffset), header.Animation8TimeOffset);
            for (ulong i = 0; i < header.Animation8Entries; i++)
            {
                UInt32 data = stream.ReadUInt32(); // TODO
            }
            stream.SkipPadding(16);

            Goto(stream, nameof(header.Animation8ValueOffset), header.Animation8ValueOffset);
            for (ulong i = 0; i < header.Animation8Entries; i++)
            {
                byte[] data = stream.ReadBytes(12); // TODO
            }
            stream.SkipPadding(16);
        }
    }

    public static void Goto(Stream stream, string field, ulong position)
    {
        stream.Goto<ModelBoneAnimation>(field, position, true);
    }
}
