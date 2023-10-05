using System.Xml.Serialization;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.xml;

[XmlRoot("chummer")]
public class ComplexFormsXmlRecord
{
    [XmlArray("complexforms")]
    [XmlArrayItem("complexform")]
    public List<ComplexForm> ComplexForms { get; set; } = new List<ComplexForm>();
}