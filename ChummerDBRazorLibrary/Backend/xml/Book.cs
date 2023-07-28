using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.xml;

public class Book: IHasName
{
    [XmlElement(ElementName = "id")]
    public Guid Id { get; set; } = Guid.Empty;

    [XmlElement(ElementName = "name")]
    public string Name { get; set; } = string.Empty;

    [XmlElement(ElementName = "code")] 
    public string Code { get; set; } = string.Empty;
}