namespace BlackDesert.Trade.Domain.Models.Xml;

public readonly struct XmlFile
{
  public string Path { get; }
  public string FileName { get; }
  public Type Type { get; }

  public XmlFile(string path, Type type) {
    this.Path = path;
    Type = type;
    FileName = System.IO.Path.GetFileNameWithoutExtension(path);
  }
}
