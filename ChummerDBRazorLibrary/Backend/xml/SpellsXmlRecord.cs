using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml;

[XmlRoot("chummer")]
public class SpellsXmlRecord
{
    [XmlArray("spells")]
    [XmlArrayItem("spell")]
    public List<Spell> Spells { get; set; } = new();
}