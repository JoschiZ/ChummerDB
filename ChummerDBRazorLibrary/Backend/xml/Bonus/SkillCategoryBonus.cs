using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml.Bonus;

[XmlRoot("skillcategory")]
public class SkillCategoryBonus: BaseBonus
{
    [XmlElement("name")] 
    public string Name { get; set; } = string.Empty;
    
    [XmlElement("bonus")]
    public int ModifierAmount { get; set; }
}