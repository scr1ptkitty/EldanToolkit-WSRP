using Godot;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace EldanToolkit.Project
{
    public partial class Project : Node
    {
        public ProjectFileSystem FileSystem {  get; private set; }
        public TableDataSet DataSet { get; private set; }

        public string ProjectPath { get; private set; }

        public string ProjectFilePath
        {
            get => Path.Join(ProjectPath, "Project.xml");
        }

        private Project()
        {
        }

        public void Save()
        {
        }

        public static Project NewProject(string path)
        {
            Project proj = new Project();
            if (proj._NewProject(path))
            {
                return proj;
            }
            return null;
        }

        private bool _NewProject(string path)
        {
            ProjectPath = path;

            FileSystem = new ProjectFileSystem();
            FileSystem.projectPath = path;
            FileSystem.MakeFolders();
            AddChild(FileSystem);

            DataSet = new TableDataSet();
            AddChild(DataSet);
            //DataSet.PrepTables(this);

            Save();
            return true;
        }

        public static Project LoadProject(string path)
        {
            Project proj = new Project();
            if (proj._LoadProject(path))
            {
                return proj;
            }
            return null;
        }

        private bool _LoadProject(string path)
        {
            ProjectPath = path;

            if (!File.Exists(ProjectFilePath))
                return false;

            FileSystem = new ProjectFileSystem();
            FileSystem.projectPath = path;
            AddChild(FileSystem);

            DataSet = new TableDataSet();
            AddChild(DataSet);
            //DataSet.PrepTables(this);

            return true;
        }

        public void ConvertFiles()
        {
            FileSystem.ConvertFiles();
        }

        public void ConvertAndCompile()
        {
            FileSystem.CompileProject();
        }
    }
}
