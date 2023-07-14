using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml.Bonus;

[XmlRoot("fatigueresist")]
public class FatigueResistBonus: BaseBonus
{
    [XmlText]
    public int ModifierAmount { get; set; }
}