using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.xml.Bonus;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.xml.Gear;

[XmlRoot("Gear")]
public class Gear: IHasSource, IHasCost, IHasName
{
        [XmlElement(ElementName = "id")] 
        public string Id { get; set; } = string.Empty;

        [XmlElement(ElementName="name")] 
        public string Name { get; set; } = string.Empty;

        [XmlElement(ElementName="category")] 
        public string Category { get; set; } = string.Empty;

        [XmlElement(ElementName = "rating")] 
        public string Rating { get; set; } = string.Empty;

        [XmlElement(ElementName="source")] 
        public string Source { get; set; } = string.Empty;

        [XmlElement(ElementName="page")] 
        public int Page { get; set; }

        [XmlElement(ElementName = "avail")] 
        public string Availability { get; set; } = string.Empty;

        [XmlElement(ElementName = "cost")] 
        public string Cost { get; set; } = string.Empty;

        [XmlArray("bonus")]
        [XmlArrayItem("essencepenaltyt100", typeof(EssencePenaltyBonus))]
        [XmlArrayItem("limitmodifier", typeof(LimitBonus))]
        [XmlArrayItem("matrixinitiativedice", typeof(MatrixInitiativeDiceBonus))]
        [XmlArrayItem("specificskill", typeof(SkillBonus))]
        [XmlArrayItem("skillattribute", typeof(SkillAttributeBonus))]
        [XmlArrayItem("spellcategory", typeof(SpellCategoryBonus))]
        [XmlArrayItem("weaponspecificdice", typeof(WeaponSpecificDiceBonus))]
        [XmlArrayItem("toxincontactimmune", typeof(ContactToxinImmunityBonus))]
        [XmlArrayItem("pathogencontactimmune", typeof(ContactPathogenImmunityBonus))]
        [XmlArrayItem("skillsoft", typeof(SkillSoftBonus))]
        [XmlArrayItem("activesoft", typeof(ActiveSoftBonus))]
        [XmlArrayItem("smartlink", typeof(SmartlinkBonus))]
        public List<BaseBonus> Bonuses { get; set; } = new();
        
        [XmlElement(ElementName = "addoncategory")]
        public List<string> AddonCategory { get; set; } = new();
        
        [XmlElement("armorcapacity")] 
        public string NeededCapacity { get; set; } = string.Empty;

        [XmlElement(ElementName = "capacity")] 
        public string Capacity { get; set; } = string.Empty; 
        
        [XmlElement(ElementName="addweapon")] 
        public string AddWeapon { get; set; } = string.Empty;
        
        [XmlElement(ElementName = "minrating")]
        public int MinRating { get; set; }
        
        [XmlArray("gears")]
        [XmlArrayItem("usegear")]
        public List<UseGear> Gears { get; set; } = new();
        
        [XmlElement(ElementName="costfor")] 
        public int UnitsPerCost { get; set; }
        
        [XmlElement(ElementName="devicerating")] 
        public string DeviceRating { get; set; } = string.Empty;
        
        [XmlElement(ElementName="weight")] 
        public int Weight { get; set; } 
        
        [XmlElement(ElementName="ammoforweapontype")] 
        public string AmmoForWeaponType { get; set; } = string.Empty;

        [XmlArray("allowgear")] 
        [XmlArrayItem("name")]
        public List<string> AllowedGear = new();
}