using System.Xml.Serialization;

namespace ChummerDB.Shared.xml.Bonus;

[XmlRoot("specificskill")]
public class SkillBonus: BaseBonus
{
    [XmlElement("name")] 
    public string Name { get; set; } = string.Empty;

    [XmlElement("bonus")] 
    public string Amount { get; set; } = string.Empty;
    
    public override string DisplayString => $"{Name}: {Amount}";
}