using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml.Bonus;

[XmlRoot("essencepenaltyt100")]
public class EssencePenaltyBonus: BaseBonus
{
    [XmlText] public string Amount { get; set; } = string.Empty;

    public override string DisplayString => Amount;
}