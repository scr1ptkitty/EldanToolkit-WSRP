using Godot;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml.Linq;
using WildStar.GameTable;
using WildStar.TestBed;
using WildStar.TextTable;

namespace EldanToolkit.Project
{
    public partial class TableDataSet : Node
    {
        public DataSet dataSet;

        private Project proj;

        private string tablePath;
        private Dictionary<string, WSTable> loadedTables = new();
        private TextTable enUS;

        public void PrepTables(Project proj)
        {
            this.proj = proj;
            tablePath = $"{proj.FileSystem.projectFilesPath}/DB/";
            Directory.CreateDirectory(tablePath);
            AddToProject("en-US.bin");
            enUS = new TextTable();
            enUS.Load(proj.FileSystem.projectFilesPath + "/en-US.bin");
        }

        public WSTable GetTable(string name)
        {
            name = name.ToLower();
            if (loadedTables.TryGetValue(name, out var table))
            {
                return table;
            }
            string path = tablePath + name + ".tbl";
            if (File.Exists(path))
            {
                AddToProject("DB/" + name + ".tbl");
                GameTable tbl = new GameTable();
                tbl.Load(tablePath + name);
                loadedTables.Add(name, tbl);
                dataSet.Tables.Add(tbl);
                SetupTable(name, tbl);
                return tbl;
            }
            return null;
        }

        public void AddToProject(string name)
        {
            if(!proj.FileSystem.IsInProject(name))
            {
                proj.FileSystem.AddtoProject(name, true);
            }
        }

        private void SetupTable(string name, WSTable table)
        {
            switch(name)
            {
                case "colorshift":
                    dataSet.Relations.Add(enUS.Columns["id"], table.Columns["localizedTextId"]);
                    break;
            }
        }

        public void GetDecorColorShift()
        {
            var tbl = GetTable("Colorshift");

        }
    }
}
