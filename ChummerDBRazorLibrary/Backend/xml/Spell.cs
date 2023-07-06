using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.xml;

[XmlRoot(ElementName="spell")]
public class Spell: IHasSource, IHasDamage, IHasDuration, IHasDrain { 

	[XmlElement(ElementName="id")] 
	public Guid Id { get; set; } 

	[XmlElement(ElementName="name")] 
	public string Name { get; set; } = string.Empty;

	[XmlElement(ElementName="page")] 
	public int Page { get; set; } 

	[XmlElement(ElementName="source")] 
	public string Source { get; set; } = string.Empty;

	[XmlElement(ElementName="category")] 
	public string Category { get; set; } = string.Empty;

	[XmlElement(ElementName="damage")] 
	public string Damage { get; set; } = string.Empty;

	[XmlElement(ElementName="descriptor")] 
	public string? Descriptor { get; set; } 

	[XmlElement(ElementName="duration")] 
	public string Duration { get; set; } = string.Empty;

	[XmlElement(ElementName="dv")] 
	public string Drain { get; set; } = string.Empty;

	[XmlElement(ElementName="range")] 
	public string Range { get; set; } = string.Empty;

	[XmlElement(ElementName="type")] 
	public string Type { get; set; } = string.Empty;
}

