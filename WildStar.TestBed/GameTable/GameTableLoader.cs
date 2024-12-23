using Godot;
using SharpCompress;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WildStar.GameTable.IO;
using WildStar.GameTable.Static;

namespace WildStar.GameTable
{
    public static class GameTableLoader
    {
		public static uint CalculateSize(IEnumerable<Type> columns, bool padEntries)
        {
            uint size = 0u;
            foreach (var column in columns)
            {
                switch (GetDataType(column))
                {
                    case DataType.Integer:
                    case DataType.Single:
                    case DataType.Boolean:
                        size += 4;
                        break;
                    case DataType.Long:
                        size += 8;
                        break;
                    case DataType.String:
                        if (size % 8 != 0)
                        {
                            size += 4;
                        }
                        size += 8;
                        break;
                }
            }

            if (padEntries && size % 8 != 0)
            {
                size += size % 8;
            }

            return size;
		}

        public static DataTable Load(string path)
        {
            /*    return await LoadAsync(path);
			}

			public static async Task<DataTable> LoadAsync(string path)
			{*/
            var sw = Stopwatch.StartNew();
            DataTable table = new DataTable();

            byte[] bytes = File.ReadAllBytesAsync(path).Result;

            Header header;
            int headerSize;
			List<string> columnsOrdered = new();

			using (var stream = new MemoryStream(bytes))
            using (var reader = new BinaryReader(stream, Encoding.Unicode))
            {
                GD.Print($"Table {path}: {sw.ElapsedMilliseconds} ms.");
                headerSize = Marshal.SizeOf<Header>();
                header = MemoryMarshal.Read<Header>(reader.ReadBytes(headerSize));

                table.SetUserData("RecordSize", header.RecordSize);


                // name
                var nameLength = reader.ReadBytes(((int)header.NameLength - 1) * 2);
                table.Name = Encoding.Unicode.GetString(nameLength);

                // columns
                long columnDataOffset = headerSize + header.ColumnOffset;
                stream.Position = columnDataOffset;
                ReadOnlySpan<TblColumn> columns = MemoryMarshal.Cast<byte, TblColumn>(
                    reader.ReadBytes(Marshal.SizeOf<TblColumn>() * (int)header.ColumnCount));

                // column names
                long columnStringTableOffset = columnDataOffset + (Marshal.SizeOf<TblColumn>() * header.ColumnCount);

                // why??
                if (columnStringTableOffset % 16 != 0)
                    columnStringTableOffset += columnStringTableOffset % 16;

                foreach (TblColumn column in columns)
                {
                    long columnNamePosition = columnStringTableOffset + column.NameOffset;
                    stream.Position = columnNamePosition;

                    var columnNameBytes = reader.ReadBytes(((int)column.NameLength - 1) * 2);
                    string columnName = Encoding.Unicode.GetString(columnNameBytes);

                    columnsOrdered.Add(columnName); // Save the original version of the column name

                    if (columnName.ToUpper() == "ID") { columnName = "ID"; } // To ensure that this field is consistent.

                    table.SetColumn(columnName, GetDataType(column.Type));
                    table.SetColumnUserData(columnName, "ColumnUnknown2", column.Unknown2);
                    table.SetColumnUserData(columnName, "ColumnUnknown3", column.Unknown3);
                }
                table.SetColumn("UID", typeof(uint));
                table.SetUserData("ColumnsOrdered", columnsOrdered); // Store the proper order of the columns, for writing later.

                GD.Print($"Table {path}: {sw.ElapsedMilliseconds} ms.");
            }


			// records
			long recordDataOffset = headerSize + header.RecordOffset;
            const long div = 100;
            ConcurrentDictionary<uint, DataRow> dict = new();
            Enumerable.Range(0, (int)header.RecordCount).AsParallel().ForEach((i) => 
            {
                using (var stream = new MemoryStream(bytes))
                using (var reader = new BinaryReader(stream, Encoding.Unicode))
                {
                    stream.Position = recordDataOffset + header.RecordSize * i;

                    DataRow row = table.NewRow();
                    foreach (string column in columnsOrdered)
                    {
                        switch (GetDataType(table.schema[column]))
                        {
                            case DataType.Integer:
                                uint intVal = reader.ReadUInt32();
                                row.SetValue(column, intVal);
                                break;
                            case DataType.Single:
                                float floatVal = reader.ReadSingle();
                                row.SetValue(column, floatVal);
                                break;
                            case DataType.Boolean:
                                bool boolVal = Convert.ToBoolean(reader.ReadUInt32());
                                row.SetValue(column, boolVal);
                                break;
                            case DataType.Long:
                                ulong longVal = reader.ReadUInt64();
                                row.SetValue(column, longVal);
                                break;
                            case DataType.String:
                                {
                                    uint offset1 = reader.ReadUInt32();
                                    uint offset2 = reader.ReadUInt32();
                                    if (offset1 == 0)
                                        reader.ReadUInt32();

                                    uint offset3 = Math.Max(offset1, offset2);

                                    // read string
                                    long position = reader.BaseStream.Position;
                                    reader.BaseStream.Position = headerSize + header.RecordOffset + offset3;

                                    string stringVal = reader.ReadWideString();
                                    row.SetValue(column, stringVal);

                                    reader.BaseStream.Position = position;


                                    break;
                                }
                        }
                    }

                    uint id = row.GetValue<uint>("ID");
                    row.SetValue("UID", id);

                    dict[id] = row;
                }
            });

            foreach (var row in dict)
            {
                table.InsertRow(row.Key, row.Value);
            }

            // ignore lookup table


            GD.Print($"Table {path}: {sw.ElapsedMilliseconds} ms");
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
                    Signature = 0x4454424C
                };

                //
                writer.Write(new byte[Marshal.SizeOf<Header>()]);

                // name
                header.NameLength = table.Name.Length + 1;
                writer.WriteWideStringPad(table.Name, 16);

                List<string> columnsOrdered = table.GetUserData<List<string>>("ColumnsOrdered"); // original columns in correct order

                // columns
                header.ColumnCount = columnsOrdered.Count;
                header.ColumnOffset = stream.Position - headerSize;
                WriteColumns(table, columnsOrdered, writer);

                // entries
                header.RecordCount = table.GetRowList().Count();
                header.RecordOffset = stream.Position - headerSize;

                bool padEntries = false;
                long recordSize = table.GetUserData<long>("RecordSize");
                var columnTypes = columnsOrdered.Select(c => table.schema[c]).ToList();

                if (header.RecordCount > 0)
                {
                    header.RecordSize = CalculateSize(columnTypes, padEntries);
                    if(header.RecordSize != recordSize)
                    {
                        padEntries = true;
                        header.RecordSize = CalculateSize(columnTypes, padEntries);
                    }
                }

                WriteEntries(table, columnsOrdered, header, writer);
                header.TotalRecordSize = stream.Position - headerSize - header.RecordOffset;

                PadTo16(writer);

                // build lookup table
                header.MaxId = table.GetMaxID() + 1;
                header.LookupOffset = stream.Position - headerSize;

                var lookup = new int[header.MaxId];
                for (int i = 0; i < header.MaxId; i++)
                    lookup[i] = -1;

                var saveRows = table.rows.ToList();

                for(int i = 0; i < saveRows.Count; i++)
                {
                    var row = saveRows[i];
					uint ID = row.Key;
					lookup[ID] = i;
				}

                for (int i = 0; i < header.MaxId; i++)
                    writer.Write(lookup[i]);

                PadTo16(writer);

                // write header
                var span = MemoryMarshal.CreateReadOnlySpan(ref header, 1);
                var bytes = MemoryMarshal.Cast<Header, byte>(span).ToArray();
                stream.Position = 0;
                writer.Write(bytes);
            }
        }

        private static void PadTo16(BinaryWriter writer)
        {
            long padding = 16 - writer.BaseStream.Position % 16L;
            if (padding == 16)
                padding = 0;

            for (int i = 0; i < padding; ++i)
                writer.Write((byte)0);
        }

        private static void WriteColumns(DataTable table, List<string> columnsOrdered, BinaryWriter writer)
        {
            using (var stringTableStream = new MemoryStream())
            using (var stringTableWriter = new BinaryWriter(stringTableStream))
            {
                var columns = new TblColumn[columnsOrdered.Count];
                for (var i = 0; i < columnsOrdered.Count; i++)
                {
                    columns[i].Type = GetDataType(table.schema[columnsOrdered[i]]);
                    columns[i].Unknown2 = table.GetColumnUserData<ushort>(columnsOrdered[i], "ColumnUnknown2");
                    columns[i].Unknown3 = table.GetColumnUserData<uint>(columnsOrdered[i], "ColumnUnknown3");


                    columns[i].NameOffset = stringTableStream.Position;
                    stringTableWriter.WriteWideStringPad(columnsOrdered[i], 16);
                    columns[i].NameLength = columnsOrdered[i].Length + 1;


                    columns[i].Write(writer);
                }

                // why??
                if (writer.BaseStream.Position % 16 != 0)
                    writer.Write(new byte[writer.BaseStream.Position % 16]);

                writer.Write(stringTableStream.ToArray());
            }
        }

        private static void WriteEntries(DataTable table, List<string> columnsOrdered, Header header, BinaryWriter writer)
        {
            uint entrySize = (uint)header.RecordSize;
            var stringTableOffset = entrySize * table.rows.Count;

            Dictionary<string, uint> stringLookup = new Dictionary<string, uint>();

            using (var stringTableStream = new MemoryStream())
            using (var stringTableWriter = new BinaryWriter(stringTableStream))
            {
                foreach (DataRow row in table.rows.Values)
                {
                    long start = writer.BaseStream.Position;
                    foreach (var column in columnsOrdered)
                    {
                        switch (GetDataType(table.schema[column]))
                        {
                            case DataType.Integer:
                                writer.Write(row.GetValue<uint>(column));
                                break;
                            case DataType.Single:
                                writer.Write(row.GetValue<float>(column));
                                break;
                            case DataType.Boolean:
                                writer.Write(Convert.ToUInt32(row.GetValue<bool>(column)));
                                break;
                            case DataType.Long:
                                writer.Write(row.GetValue<ulong>(column));
                                break;
                            case DataType.String:
                                string cell = row.GetValue<string>(column);
                                long a = (writer.BaseStream.Position - start) % 8;
                                if (a != 0)
                                {
                                    writer.Write((uint)0);
                                }
                                uint stringPosition = 0;
                                if (stringLookup.TryGetValue((string)cell, out uint position))
                                {
                                    stringPosition = position;
                                }
                                else
                                {
                                    stringPosition = (uint)stringTableOffset + (uint)stringTableStream.Position;
                                    stringLookup.Add((string)cell, stringPosition);

                                    stringTableWriter.WriteWideString((string)cell);
                                }
                                writer.Write(stringPosition);
                                writer.Write((uint)0);
                                break;
                        }
                    }

                    long end = writer.BaseStream.Position - start;
                    if (end != entrySize)
                    {
                        long difference = entrySize - end;
                        writer.Write(new byte[difference]);
                    }
                }

                writer.Write(stringTableStream.ToArray());
            }
        }

        public static Type GetDataType(DataType type)
        {
            switch (type)
            {
                case DataType.Boolean:
                    return typeof(bool);
                case DataType.Integer:
                    return typeof(uint);
                case DataType.Single:
                    return typeof(float);
                case DataType.Long:
                    return typeof(ulong);
                case DataType.String:
                    return typeof(string);
                default:
                    return typeof(void);
            }
        }

        public static DataType GetDataType(Type type)
        {
            if (type == typeof(bool))
            {
                return DataType.Boolean;
            }
            if (type == typeof(uint))
            {
                return DataType.Integer;
            }
            if (type == typeof(float))
            {
                return DataType.Single;
            }
            if (type == typeof(ulong))
            {
                return DataType.Long;
            }
            if (type == typeof(string))
            {
                return DataType.String;
            }
            return DataType.Long;
        }
    }
}
