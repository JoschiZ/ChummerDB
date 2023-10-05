using System.Xml.Serialization;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.xml;

[XmlRoot("chummer")]
public sealed class ArmorXmlRecord
{
    [XmlArray("armors")]
    [XmlArrayItem("armor")]
    public List<Armor> Armors { get; set; } = new List<Armor>();
    
    [XmlArray("mods")]
    [XmlArrayItem("mod")]
    public List<ArmorMod> Mods { get; set; } = new List<ArmorMod>();
}