using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml;

public class Book
{
    [XmlElement(ElementName = "id")]
    public Guid Id { get; set; } = Guid.Empty;

    [XmlElement(ElementName = "name")]
    public string Name { get; set; } = string.Empty;

    [XmlElement(ElementName = "code")] 
    public string Code { get; set; } = string.Empty;
}