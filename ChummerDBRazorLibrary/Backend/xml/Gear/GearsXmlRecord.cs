using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.Util;

namespace ChummerDBRazorLibrary.Backend.xml.Gear;

[XmlRoot("chummer")]

public class GearsXmlRecord
{
    [XmlArray("gears")]
    [XmlArrayItem("gear", typeof(Gear))]
    [XmlArrayItem("Ammunition", typeof(Ammunition))]
    public List<Gear> Gears { get; } = new();
}