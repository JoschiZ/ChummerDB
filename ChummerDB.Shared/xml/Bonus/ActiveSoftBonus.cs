using System.Xml.Serialization;

namespace ChummerDB.Shared.xml.Bonus;

[XmlRoot(ElementName="activesoft")]
public class ActiveSoftBonus: BaseBonus
{
    public override string DisplayString => $"+{Amount} Activesoft";

    [XmlElement(ElementName = "val")] 
    public string Amount { get; set; } = string.Empty;
}