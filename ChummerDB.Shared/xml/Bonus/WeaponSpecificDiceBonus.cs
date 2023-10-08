using System.Xml.Serialization;

namespace ChummerDB.Shared.xml.Bonus;

[XmlRoot(ElementName="weaponspecificdice")]
public class WeaponSpecificDiceBonus: BaseBonus { 

    [XmlAttribute(AttributeName="type")] 
    public string Type { get; set; } = string.Empty;

    [XmlText] 
    public string Amount { get; set; } = string.Empty;

    public override string DisplayString => $"+{Amount} {Type}";
}