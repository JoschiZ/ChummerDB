using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.Enums;

namespace ChummerDBRazorLibrary.Backend.xml.Bonus;

[XmlRoot("limitmodifier")]
public class LimitBonus: BaseBonus
{
    [XmlElement("limit")]
    public Limit Limit { get; set; }

    [XmlElement("value")] 
    public string ModifierAmount { get; set; } = string.Empty;
    
    [XmlElement("condition")]
    public string? Condition { get; set; }
}