using System.Xml.Serialization;

namespace ChummerDB.Shared.xml.Bonus;

[XmlRoot(ElementName="smartlink")] 
public class SmartlinkBonus: BaseBonus
{
    public override string DisplayString => "Smartlink";
    
    [XmlText]
    public int Smartlink { get; set; } 

}