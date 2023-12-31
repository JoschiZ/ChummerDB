using System.Xml.Serialization;
using ChummerDB.Shared.xml.Interfaces;

namespace ChummerDB.Shared.xml;

[XmlRoot(ElementName="complexform")]
public class ComplexForm: IHasSource, IHasDuration, IHasDrain, IHasName { 

    [XmlElement(ElementName="id")] 
    public Guid Id { get; set; }

    [XmlElement(ElementName = "name")] 
    public string Name { get; set; } = string.Empty;

    [XmlElement(ElementName="target")] 
    public string Target { get; set; } = string.Empty;

    [XmlElement(ElementName="duration")] 
    public string Duration { get; set; } = string.Empty;

    [XmlElement(ElementName="fv")] 
    public string Drain { get; set; } = string.Empty;

    [XmlElement(ElementName="source")] 
    public string Source { get; set; } = string.Empty;

    [XmlElement(ElementName="page")] 
    public int Page { get; set; }
}