using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml.Gear;

[XmlRoot(ElementName="Ammunition")]
public class Ammunition: Gear { 

	[XmlElement(ElementName="ammoforweapontype")] 
	public string AmmoForWeaponType { get; set; } = string.Empty;

	[XmlElement(ElementName="addweapon")] 
	public string AddWeapon { get; set; } = string.Empty;
	
	[XmlElement(ElementName="costfor")] 
	public int UnitsPerCost { get; set; }

	[XmlElement(ElementName = "addoncategory")]
	public List<string> AddonCategory { get; set; } = new();

	[XmlElement(ElementName="weaponbonus")]
	public WeaponBonus? WeaponBonus { get; set; } 
	
	[XmlElement(ElementName="flechetteweaponbonus")]
	public WeaponBonus? FlechetteWeaponBonus { get; set; }
	
	// TODO: This is actually a boolean... implement it as such!
	[XmlElement(ElementName = "isflechetteammo")]
	public string IsFlechetteAmmo { get; set; }
}


public class WeaponBonus { 

	[XmlElement(ElementName="ap")] 
	public int Ap { get; set; } 

	[XmlElement(ElementName="damage")] 
	public string Damage { get; set; } 

	[XmlElement(ElementName="damagetype")] 
	public string DamageType { get; set; } = string.Empty;

	[XmlElement(ElementName="apreplace")] 
	public int ApReplace { get; set; } 

	[XmlElement(ElementName="damagereplace")] 
	public string DamageReplace { get; set; } = string.Empty;

	[XmlElement(ElementName="modereplace")] 
	public string ModeReplace { get; set; } = string.Empty;

	[XmlElement(ElementName="userange")] 
	public string UseRange { get; set; } = string.Empty;

	[XmlElement(ElementName="accuracy")] 
	public int Accuracy { get; set; } 

	[XmlElement(ElementName="accuracyreplace")] 
	public int AccuracyReplace { get; set; } 
}