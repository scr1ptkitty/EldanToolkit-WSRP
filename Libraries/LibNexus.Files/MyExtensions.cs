using LibNexus.Files;
using System.Diagnostics;
using System.IO;

namespace EldanToolkit.Libraries.LibNexus.Files
{
    public static class MyExtensions
    {
        public static void Goto<T>(this Stream stream, string field, ulong position, bool debug)
        {
            FileFormatException.ThrowIf<T>(field, stream.Position != (long)position && debug);
            stream.Position = (long)position;
        }

        public static ulong RoundUpTo(this ulong value, ulong round)
        {
            if (value % round != 0)
            {
                value = round + (value / round) * round; // rough ceil() that doesn't work when value % round == 0, but isn't needed in that case.
            }
            return value;
        }
    }
}
