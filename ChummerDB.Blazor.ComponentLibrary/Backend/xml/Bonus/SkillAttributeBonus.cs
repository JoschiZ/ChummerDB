using System.Xml.Serialization;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.xml.Bonus;

[XmlRoot("skillattribute")]
public class SkillAttributeBonus: BaseBonus
{
    public override string DisplayString => $"+{Bonus} {Name}";

    [XmlElement(ElementName = "name")] 
    public string Name { get; set; } = string.Empty;

    [XmlElement(ElementName="bonus")] 
    public string Bonus { get; set; }  = string.Empty;

    [XmlAttribute(AttributeName="precedence")] 
    public int Precedence { get; set; }
}