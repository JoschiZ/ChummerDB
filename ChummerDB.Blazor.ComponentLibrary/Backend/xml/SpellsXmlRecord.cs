using System.Xml.Serialization;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.xml;

[XmlRoot("chummer")]
public class SpellsXmlRecord
{
    [XmlArray("spells")]
    [XmlArrayItem("spell")]
    public List<Spell> Spells { get; set; } = new();
}