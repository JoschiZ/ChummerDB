using System.Xml.Serialization;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.xml.Bonus;

[XmlRoot(ElementName="skillsoft")]
public class SkillSoftBonus: BaseBonus
{
    public override string DisplayString => $"+{Amount} Skillsoft";

    [XmlElement(ElementName = "val")] 
    public string Amount { get; set; } = string.Empty;
}