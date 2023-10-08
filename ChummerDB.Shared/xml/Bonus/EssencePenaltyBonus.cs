using System.Xml.Serialization;

namespace ChummerDB.Shared.xml.Bonus;

[XmlRoot("essencepenaltyt100")]
public class EssencePenaltyBonus: BaseBonus
{
    [XmlText] public string Amount { get; set; } = string.Empty;

    public override string DisplayString => Amount;
}