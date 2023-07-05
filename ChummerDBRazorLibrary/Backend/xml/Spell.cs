using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.xml;

[XmlRoot(ElementName="spell")]
public class Spell: IHasSource, IHasDamage { 

	[XmlElement(ElementName="id")] 
	public Guid Id { get; set; } 

	[XmlElement(ElementName="name")] 
	public string Name { get; set; } 

	[XmlElement(ElementName="page")] 
	public int Page { get; set; } 

	[XmlElement(ElementName="source")] 
	public string Source { get; set; } 

	[XmlElement(ElementName="category")] 
	public string Category { get; set; } 

	[XmlElement(ElementName="damage")] 
	public string Damage { get; set; } 

	[XmlElement(ElementName="descriptor")] 
	public string? Descriptor { get; set; } 

	[XmlElement(ElementName="duration")] 
	public string Duration { get; set; } 

	[XmlElement(ElementName="dv")] 
	public string Dv { get; set; } 

	[XmlElement(ElementName="range")] 
	public string Range { get; set; } 

	[XmlElement(ElementName="type")] 
	public string Type { get; set; }
}

