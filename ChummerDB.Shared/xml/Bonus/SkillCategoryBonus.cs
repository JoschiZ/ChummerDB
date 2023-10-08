using System.Xml.Serialization;

namespace ChummerDB.Shared.xml.Bonus;

[XmlRoot("skillcategory")]
public class SkillCategoryBonus: BaseBonus
{
    [XmlElement("name")] 
    public string Name { get; set; } = string.Empty;
    
    [XmlElement("bonus")]
    public int Amount { get; set; }
    
    public override string DisplayString => $"{Name}: {Amount}";
}