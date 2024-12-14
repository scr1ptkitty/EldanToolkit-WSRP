using System;

namespace LibNexus.Files;

public class FileFormatException : Exception
{
	public FileFormatException(Type source, string field)
		: base($"{source.FullName}: Invalid {field}")
	{
	}

	public static void ThrowIf<T>(string field, bool condition)
	{
		if (condition)
			throw new FileFormatException(typeof(T), field);
	}
}
