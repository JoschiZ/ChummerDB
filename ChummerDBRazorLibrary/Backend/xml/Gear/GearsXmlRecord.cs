using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml.Gear;

[XmlRoot("chummer")]

public class GearsXmlRecord
{
    [XmlArray("gears")]
    [XmlArrayItem("gear", typeof(Gear))]
    [XmlArrayItem("Ammunition", typeof(Ammunition))] // This Element is created in a TransFormer
    [XmlArrayItem("ElectronicGear", typeof(ElectronicGear))] // This Element is created in a TransFormer
    public List<Gear> AllGears { get; } = new();
}