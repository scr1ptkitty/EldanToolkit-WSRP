using System.IO;
using System.Xml.Serialization;

[XmlRoot("IndexToolXml")]
public class IndexToolXML
{
	[XmlArray("Folders")]
	[XmlArrayItem("Folder")]
	public ITFileFolder[] folders;

	public static IndexToolXML Read(string filePath)
	{
		var serializer = new XmlSerializer(typeof(IndexToolXML));
		using (var reader = new StreamReader(filePath))
		{
			return (IndexToolXML)serializer.Deserialize(reader);
		}
	}

	public void Write(string filePath)
	{
		var serializer = new XmlSerializer(typeof(IndexToolXML));
		using (var writer = new StreamWriter(filePath))
		{
			serializer.Serialize(writer, this);
		}
	}
}

[XmlType("FileFolder")]
public class ITFileFolder
{
	[XmlAttribute("basePath")]
	public string basePath;

	[XmlArray("Files")]
	[XmlArrayItem("File")]
	public ITFile[] files;
}

[XmlType("File")]
public class ITFile
{
	[XmlAttribute("filePath")]
	public string filePath;
}