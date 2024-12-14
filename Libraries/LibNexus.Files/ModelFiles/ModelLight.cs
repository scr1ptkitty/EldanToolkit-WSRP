using EldanToolkit.Libraries.LibNexus.Files;
using LibNexus.Core.Extensions;
using LibNexus.Core.Streams;
using System.Diagnostics;
using System.IO;

namespace LibNexus.Files.ModelFiles;

public class ModelLight
{
	private readonly ModelLightHeader _header;

	public ModelLight(Stream stream, ulong length)
	{
		_header = new ModelLightHeader(stream, length);
		stream.SkipPadding(16);
	}

    public static void Goto(Stream stream, string field, ulong position)
    {
        stream.Goto<ModelGeometry>(field, position, Model.Debug);
    }
}
