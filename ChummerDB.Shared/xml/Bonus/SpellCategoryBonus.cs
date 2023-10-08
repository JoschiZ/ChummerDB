using System.Xml.Serialization;

namespace ChummerDB.Shared.xml.Bonus;

[XmlRoot(ElementName="spellcategory")]
public class SpellCategoryBonus: BaseBonus
{
    public override string DisplayString => $"+{Amount} {Name}";

    [XmlElement(ElementName = "name")] 
    public string Name { get; set; } = string.Empty;

    [XmlElement(ElementName="val")] 
    public string Amount { get; set; } = string.Empty;
    
}