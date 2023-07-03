// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Spells));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Spells)serializer.Deserialize(reader);
// }

using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend;

[XmlRoot(ElementName="spell")]
public class Spell: IHasSource { 

	[XmlElement(ElementName="id")] 
	public string Id { get; set; } 

	[XmlElement(ElementName="name")] 
	public string Name { get; set; } 

	[XmlElement(ElementName="page")] 
	public int Page { get; set; } 

	[XmlElement(ElementName="source")] 
	public string Book { get; set; } 

	[XmlElement(ElementName="category")] 
	public string Category { get; set; } 

	[XmlElement(ElementName="damage")] 
	public string Damage { get; set; } 

	[XmlElement(ElementName="descriptor")] 
	public string Descriptor { get; set; } 

	[XmlElement(ElementName="duration")] 
	public string Duration { get; set; } 

	[XmlElement(ElementName="dv")] 
	public string Dv { get; set; } 

	[XmlElement(ElementName="range")] 
	public string Range { get; set; } 

	[XmlElement(ElementName="type")] 
	public string Type { get; set; }
    
	[XmlIgnore]
	public string Source => $"{Page} {Book}";
}

public interface IHasSource
{
	public string Source { get; }
}