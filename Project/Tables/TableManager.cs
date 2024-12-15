using EldanToolkit.Shared;
using Godot;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;
using WildStar.GameTable;
using WildStar.TestBed;
using WildStar.TextTable;

namespace EldanToolkit.Project
{
    public partial class TableManager : Node
    {
        private Project proj;

        private string tablePath => $"{proj.FileSystem.projectFilesPath}/DB/";
		private Dictionary<string, WSTable> loadedTables = new();
        private TextTable enUS;

        public void PrepTables(Project proj)
        {
            this.proj = proj;
            Directory.CreateDirectory(tablePath);
            AddToProject("en-US.bin");
            enUS = new TextTable();
            enUS.Load(proj.FileSystem.projectFilesPath + "/en-US.bin");
        }

        public async Task<WSTable> GetTableAsync(GameTableName name)
        {
            if (loadedTables.TryGetValue(name.ToString(), out var table))
            {
                return table;
            }

            string path = tablePath + name + ".tbl";
            if (File.Exists(path))
            {
                AddToProject("DB/" + name + ".tbl");

                return await Task.Run(() =>
                {
                    GameTable tbl = new GameTable();
                    tbl.Load(tablePath + name);
                    loadedTables.Add(name.ToString(), tbl);
                    return tbl;
                });
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
    }
}
