using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.xml.Bonus;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.xml;

[XmlRoot(ElementName="mod")]
public class ArmorMod: IHasSource, IHasName
{ 

	[XmlElement(ElementName="id")] 
	public Guid Id { get; set; } 

	[XmlElement(ElementName="name")] 
	public string Name { get; set; } = string.Empty;

	[XmlElement(ElementName="category")] 
	public string Category { get; set; } = string.Empty;

	[XmlElement(ElementName="armor")] 
	public int Armor { get; set; } 

	[XmlElement(ElementName="maxrating")] 
	public int MaxRating { get; set; } 

	[XmlElement(ElementName="armorcapacity")] 
	public string ArmorCapacity { get; set; } = string.Empty;

	[XmlElement(ElementName = "avail")] 
	public string Availability { get; set; } = string.Empty;

	[XmlElement(ElementName = "cost")] 
	public string Cost { get; set; } = string.Empty;

	[XmlElement(ElementName="source")] 
	public string Source { get; set; } = string.Empty;

	[XmlElement(ElementName="page")] 
	public int Page { get; set; } 

	[XmlArray("bonus")]
	[XmlArrayItem("fatigueresist", typeof(FatigueResistBonus))]
	[XmlArrayItem("limitmodifier", typeof(LimitBonus))]
	[XmlArrayItem("skillcategory", typeof(SkillCategoryBonus))]
	[XmlArrayItem("specificskill", typeof(SkillBonus))]
	[XmlArrayItem("toxininhalationimmune", typeof(InhalationToxinImmunityBonus))]
	[XmlArrayItem("toxincontactimmune", typeof(ContactToxinImmunityBonus))]
	[XmlArrayItem("pathogencontactimmune", typeof(ContactPathogenImmunityBonus))]
	[XmlArrayItem("pathogeninhalationimmune", typeof(InhalationPathogenImmunityBonus))]
	[XmlArrayItem("firearmor", typeof(FireResistBonus))]
	[XmlArrayItem("coldarmor", typeof(ColdResistBonus))]
	[XmlArrayItem("electricityarmor", typeof(ElectricityResistBonus))]
	[XmlArrayItem("toxincontactresist", typeof(ContactToxinResist))]
	[XmlArrayItem("pathogencontactresist", typeof(PathogenContactResist))]
	public List<BaseBonus> Bonuses { get; set; } = new();

	[XmlElement(ElementName="gearcapacity")] 
	public int GearCapacity { get; set; }

	[XmlElement(ElementName = "addoncategory")]
	public List<string> AddonCategory { get; set; } = new ();

	[XmlArray("wirelessbonus")]
	[XmlArrayItem("fatigueresist", typeof(FatigueResistBonus))]
	[XmlArrayItem("limitmodifier", typeof(LimitBonus))]
	[XmlArrayItem("skillcategory", typeof(SkillCategoryBonus))]
	[XmlArrayItem("specificskill", typeof(SkillBonus))]
	[XmlArrayItem("toxininhalationimmune", typeof(InhalationToxinImmunityBonus))]
	[XmlArrayItem("toxincontactimmune", typeof(ContactToxinImmunityBonus))]
	[XmlArrayItem("pathogencontactimmune", typeof(ContactPathogenImmunityBonus))]
	[XmlArrayItem("pathogeninhalationimmune", typeof(InhalationPathogenImmunityBonus))]
	[XmlArrayItem("firearmor", typeof(FireResistBonus))]
	[XmlArrayItem("coldarmor", typeof(ColdResistBonus))]
	[XmlArrayItem("electricityarmor", typeof(ElectricityResistBonus))]
	[XmlArrayItem("toxincontactresist", typeof(ContactToxinResist))]
	[XmlArrayItem("pathogencontactresist", typeof(PathogenContactResist))]
	public List<BaseBonus> WirelessBonuses { get; set; } = new();
}