using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Data.xml;

[XmlRoot("chummer")]
public class SpellsXmlRecord
{
    [XmlArray("spells")]
    [XmlArrayItem("spell")]
    public List<Spell> Spells { get; set; } = new();
}