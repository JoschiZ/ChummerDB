using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml.Bonus;

[XmlRoot("fatigueresist")]
public class FatigueResistBonus: BaseBonus
{
    [XmlText]
    public int Amount { get; set; }

    public string Name => "Fatigue Resistance";
    
    public override string DisplayString => $"{Name}: {Amount}";
}