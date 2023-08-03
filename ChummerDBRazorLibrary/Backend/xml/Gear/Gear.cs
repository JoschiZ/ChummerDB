using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.xml.Bonus;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.xml.Gear;

[XmlRoot("Gear")]
public class Gear: IHasSource, IHasCost, IHasName
{
        [XmlElement(ElementName = "id")] public string Id { get; set; } = string.Empty;

        [XmlElement(ElementName="name")] 
        public string Name { get; set; } = string.Empty;

        [XmlElement(ElementName="category")] 
        public string Category { get; set; } = string.Empty;

        [XmlElement(ElementName = "rating")] public string Rating { get; set; } = string.Empty;

        [XmlElement(ElementName="source")] 
        public string Source { get; set; } = string.Empty;

        [XmlElement(ElementName="page")] 
        public int Page { get; set; }

        [XmlElement(ElementName = "avail")] public string Availability { get; set; } = string.Empty;

        [XmlElement(ElementName = "cost")] public string Cost { get; set; } = string.Empty;

        [XmlArray("bonus")]
        [XmlArrayItem("essencepenaltyt100", typeof(EssencePenaltyBonus))]
        public List<BaseBonus> Bonuses { get; set; } = new();
}