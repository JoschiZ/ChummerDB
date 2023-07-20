using System.Text;
using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.Enums;
using Microsoft.Extensions.Primitives;

namespace ChummerDBRazorLibrary.Backend.xml.Bonus;

[XmlRoot("limitmodifier")]
public class LimitBonus: BaseBonus
{
    [XmlElement("limit")]
    public Limit Limit { get; set; }

    [XmlElement("value")] 
    public string Amount { get; set; } = string.Empty;
    
    //TODO: Parse this condition for later display
    [XmlElement("condition")]
    public string? Condition { get; set; }
    
    public override string DisplayString => GetDisplayString();

    private string GetDisplayString()
    {
        var amount = Amount;
        var condition = (Condition ?? string.Empty).Replace("LimitCondition_", "");

        var sign = !amount.StartsWith("-") ? "+" : string.Empty;

        return $"{sign}{amount} {Limit} Limit if {condition}";
    }
}