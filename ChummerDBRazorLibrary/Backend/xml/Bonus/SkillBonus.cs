using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml.Bonus;

[XmlRoot("specificskill")]
public class SkillBonus: BaseBonus
{
    [XmlElement("name")] 
    public string Name { get; set; } = string.Empty;
    
    [XmlElement("bonus")]
    public int ModifierAmount { get; set; }
}