using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using WildStar.GameTable;
using WildStar.TextTable.IO;
using WildStar.TextTable.Static;

namespace WildStar.TextTable
{
    public static class TextTableLoader
    {
        public static DataTable Load(string path)
		{
            DataTable table = new DataTable();
            table.SetColumn("UID", typeof(uint));
			table.SetColumn("ID", typeof(uint));
			table.SetColumn("Text", typeof(string));

			using (FileStream stream = File.OpenRead(path))
            using (var reader = new BinaryReader(stream, Encoding.Unicode))
            {
                var headerSize = Marshal.SizeOf<Header>();
                Header header = MemoryMarshal.Read<Header>(reader.ReadBytes(headerSize));

                // names
                stream.Position = header.NameOffset + headerSize;
                table.Name = reader.ReadWideString((int)header.NameLength);

                stream.Position = header.CodeOffset + headerSize;
                table.SetUserData<string>("Code", reader.ReadWideString((int)header.CodeLength));

                stream.Position = header.DescriptionOffset + headerSize;
                table.SetUserData<string>("Description", reader.ReadWideString((int)header.DescriptionLength));

				table.SetUserData<Language>("Language", header.Language);

				table.SetUserData<uint>("Unknown1", header.Unknown1);
                
                // text table
				stream.Position = headerSize + header.StringTableOffset;
                byte[] data = reader.ReadBytes((int)header.StringTableLength * 2);
                var stringTable = new StringTable(data);

                //
                stream.Position = headerSize + header.RecordOffset;
                for (int i = 0; i < header.RecordCount; i++)
                {
                    uint id = reader.ReadUInt32();
                    uint bla = reader.ReadUInt32() * 2;
                    DataRow row = table.NewRow();
                    row.SetValue("UID", id); // Just use the raw ID for any tables being loaded from disk.
                    row.SetValue("ID", id);
                    row.SetValueRaw("Text", stringTable.GetString(bla));
                    table.InsertRow(id, row);
                }
            }
			return table;
		}

        public static void Save(DataTable table, string path)
        {
            using (FileStream stream = File.OpenWrite(path))
            using (var writer = new BinaryWriter(stream))
            {
                var headerSize = Marshal.SizeOf<Header>();

                var header = new Header
                {
                    Signature = 0x4C544558,
                    Version = 4,
                    Language = table.GetUserData<Language>("Language"),
                    Unknown1 = table.GetUserData<uint>("Unknown1")
				};

                writer.Write(new byte[headerSize]);

				string code = table.GetUserData<string>("Code");
				string description = table.GetUserData<string>("Description");

				// names
				header.NameLength = table.Name.Length + 1;
                header.NameOffset = stream.Position - headerSize;
                writer.WriteWideStringPad(table.Name, 16);

                header.CodeLength = code.Length + 1;
                header.CodeOffset = stream.Position - headerSize;
                writer.WriteWideStringPad(code, 16);

                header.DescriptionLength = description.Length + 1;
                header.DescriptionOffset = stream.Position - headerSize;
                writer.WriteWideStringPad(description, 16);

                // entries
                header.RecordCount = table.GetRowList().Count();
                header.RecordOffset = stream.Position - headerSize;
                header.StringTableOffset = header.RecordOffset + 8 * header.RecordCount;
				header.StringTableLength = WriteEntries(table, writer);

                // write header
                var span = MemoryMarshal.CreateReadOnlySpan(ref header, 1);
                var bytes = MemoryMarshal.Cast<Header, byte>(span).ToArray();
                stream.Position = 0;
                writer.Write(bytes);
            }
        }

        private static int WriteEntries(DataTable table, BinaryWriter writer)
        {
            using (var stringTableStream = new MemoryStream())
            using (var stringTableWriter = new BinaryWriter(stringTableStream))
            {
                var list = table.GetRowList().ToArray();
                foreach (var row in list)
                {
                    writer.Write(row.Value.GetValue<uint>("ID"));
                    writer.Write((uint)(stringTableStream.Position / 2));

                    stringTableWriter.WriteWideString(row.Value.GetValue<string>("Text"));
                }

                byte[] ss = stringTableStream.ToArray();
                writer.Write(ss);
                return ss.Length / 2;
            }
        }
    }
}
