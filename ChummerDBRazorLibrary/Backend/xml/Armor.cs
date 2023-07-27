using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.xml.Bonus;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.xml;

[XmlRoot(ElementName="armor")]
public class Armor: IHasSource, IHasCost, IHasAvailability
{

	[XmlElement(ElementName = "id")] 
	public Guid Id { get; set; }

	[XmlElement(ElementName = "name")] 
	public string Name { get; set; } = string.Empty;

	[XmlElement(ElementName="category")] 
	public string Category { get; set; }  = string.Empty;

	[XmlElement(ElementName = "armor")] 
	public string ArmorClass { get; set; } = string.Empty;

	[XmlElement(ElementName = "armorcapacity")]
	public string ArmorCapacity { get; set; } = string.Empty;

	[XmlElement(ElementName = "avail")] 
	public string Availability { get; set; } = string.Empty;

	[XmlElement(ElementName="cost")] 
	public string Cost { get; set; }  = string.Empty;

	[XmlElement(ElementName="source")] 
	public string Source { get; set; }  = string.Empty;

	[XmlElement(ElementName="page")] 
	public int Page { get; set; }
    
	//TODO: Add cards linked to the gears
	[XmlArray("gears")]
	[XmlArrayItem("usegear")]
	public List<Gear> Gears { get; set; } = new(); 
	
	
	[XmlElement(ElementName="addmodcategory")] 
	public string AddModCategory { get; set; }  = string.Empty;
	
	// TODO: Link this to the actual weapons? Should be done in the view model
	[XmlElement(ElementName="addweapon")] 
	public string AddWeapon { get; set; }  = string.Empty;
    

	[XmlArray("bonus")]
	[XmlArrayItem("fatigueresist", typeof(FatigueResistBonus))]
	[XmlArrayItem("limitmodifier", typeof(LimitBonus))]
	[XmlArrayItem("skillcategory", typeof(SkillCategoryBonus))]
	[XmlArrayItem("specificskill", typeof(SkillBonus))]
	public List<BaseBonus> Bonuses { get; set; } = new();

	[XmlArray("wirelessbonus")]
	[XmlArrayItem("fatigueresist", typeof(FatigueResistBonus))]
	[XmlArrayItem("limitmodifier", typeof(LimitBonus))]
	[XmlArrayItem("skillcategory", typeof(SkillCategoryBonus))]
	[XmlArrayItem("specificskill", typeof(SkillBonus))]
	public List<BaseBonus> WirelessBonuses { get; set; } = new();


	//TODO: This has a rating and maxrating attribute that is currently ignored
	[XmlArray("mods")]
	[XmlArrayItem("name")]
	public List<string> Mods { get; set; } = new List<string>();

	[XmlElement(ElementName="armoroverride")] 
	public int StackingArmor { get; set; }

	[XmlArray(ElementName = "selectmodsfromcategory")]
	[XmlArrayItem("category")]
	public List<string> SelectModsFromCategory { get; set; } = new List<string>();

	[XmlElement(ElementName="rating")] 
	public int Rating { get; set; } 
}
