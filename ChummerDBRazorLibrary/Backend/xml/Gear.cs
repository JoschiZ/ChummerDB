using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml;

[XmlRoot("usegear")]
public class Gear
{
    [XmlText]
    public string? NameNode { get; set; }
    
    [XmlElement("name")]
    public string? NameElement { get; set; }
    
    public string Name => NameNode ?? NameElement ?? string.Empty;

    [XmlElement("category")]
    public string Category { get; set; } = string.Empty;
    
    [XmlElement("rating")]
    public int Rating { get; set; }
    
    [XmlElement("capacity")]
    public string Capacity { get; set; } = string.Empty;
}