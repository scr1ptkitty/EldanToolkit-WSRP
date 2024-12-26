using EldanToolkit.Project;
using EldanToolkit.Shared;
using Godot;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("ImportFile")]
public class ImportFile
{
	[XmlIgnore]
	public string FilePath;

	public static ImportFile Load(string path)
	{
		using var reader = XmlReader.Create(path);
		XmlSerializer serializer = new XmlSerializer(typeof(ImportFile), TypeList());
		ImportFile file = (ImportFile)serializer.Deserialize(reader);
		file.FilePath = path;
		return file;
	}

	public static void Save(string path, ImportFile file)
	{
		XmlWriterSettings settings = new XmlWriterSettings { Indent = true };
		using var writer = XmlWriter.Create(path, settings);
		XmlSerializer serializer = new XmlSerializer(typeof(ImportFile), TypeList());
		serializer.Serialize(writer, file);
	}

	public static Type[] TypeList()
	{
		// use reflection to get all derived types
		return Assembly.GetExecutingAssembly().GetTypes().Where(
			t => typeof(ConvertData).IsAssignableFrom(t)).ToArray();
	}

	public bool NeedsConversion(string source, string dest)
	{
		return true;
	}

	public string[] Import(string dest, bool forceConvert)
	{
		if(type == ConvertType.Copy)
		{
			Directory.CreateDirectory(dest.GetBaseDir());
			File.Copy(FilePath.GetBaseName(), dest, true); // includes path, excludes .import
			return [dest];
		}
		else if(convertData != null)
		{
			return convertData.Import(FilePath, dest);
		}
		return null;
	}

	public enum ConvertType
	{
		[XmlEnum("Copy")]
		Copy,
		PNG2TEX,
		GameTable
	}

	public void FixConvertData()
	{
		switch(type)
		{
			case ConvertType.Copy:
				convertData = null;
				break;
			case ConvertType.PNG2TEX:
				convertData = convertData as PNG2TEX ?? new PNG2TEX();
				break;
			case ConvertType.GameTable:
				convertData = convertData as GameTableData ?? new GameTableData();
				break;
		}
	}

	[XmlAttribute("ConvertType")]
	public ConvertType type;

	[XmlElement("ConvertData")]
	public ConvertData convertData = null;

	public enum TargetArchive
	{
		Client64,
		ClientData,
		ClientDataDE,
		ClientDataEN,
		ClientDataFR
	}

	[XmlAttribute("Archive")]
	public TargetArchive targetArchive = TargetArchive.ClientData;
}

[XmlType("ConvertData")]
public abstract class ConvertData
{
	public abstract string[] Import(string source, string dest);
}

[XmlType("PNG2TEX")]
public class PNG2TEX : ConvertData
{
	[XmlAttribute("Depth")]
	public int depth = 1; // for LUTs and 3D textures
	[XmlAttribute("Mipmaps")]
	public int mipmaps = 1;

	public enum TexType
	{
		JPG1,
		JPG2,
		JPG3,
		ARGB1,
		ARGB2,
		RGB,
		GRAYSCALE,
		DXT1,
		DXT3,
		DXT5,
	}
	[XmlAttribute("TexType")]
	public TexType texType = TexType.DXT3;

	public override string[] Import(string source, string dest)
	{
		string srcfile = source.GetBaseName();
		if(srcfile.GetExtension().ToLower() != "tex")
		{
			return null;
		}
		NexusVaultWrapper.DoConvert(srcfile.GetBaseName() + ".png", dest, $"--png2tex-mipmaps {mipmaps}", $"--png2tex-depth {depth}", $"--png2tex-type {texType.ToString()}");
		return [dest];
	}
}

[XmlType("GameTable")]
public class GameTableData : ConvertData
{
	public override string[] Import(string source, string dest)
	{
		string DBPath = Path.GetDirectoryName(source);
		string destPath = Path.GetDirectoryName(dest);
		Directory.CreateDirectory(destPath);

		TableModManager tmm = new TableModManager(ProjectHolder.project);
		return tmm.ExportMods(destPath);
	}
}