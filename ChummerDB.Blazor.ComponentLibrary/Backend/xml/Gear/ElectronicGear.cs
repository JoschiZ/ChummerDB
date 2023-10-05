using System.Xml.Serialization;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.xml.Gear;

/**
 * Roots:
 * CommlinkAccessories
 * CommlinkCyberdeckFormFactors
 * Commlinks
 * CommlinkAccessories
 * CustomCyberdeckAttributes
 * CyberdeckModules
 * Cyberdecks
 * Cyberterminals
 * ElectronicModification
 * Entertainment
 * RFIDTags
 * RiggerCommandConsoles
 */
public class ElectronicGear: Gear
{
      [XmlElement(ElementName="programs")] 
      public string Programs { get; set; } = string.Empty;
      
      [XmlElement(ElementName="attack")] 
      public string Attack { get; set; } = string.Empty;

      [XmlElement(ElementName="sleaze")] 
      public string Sleaze { get; set; } = string.Empty;

      [XmlElement(ElementName="dataprocessing")] 
      public string DataProcessing { get; set; } = string.Empty;

      [XmlElement(ElementName="firewall")] 
      public string Firewall { get; set; } = string.Empty;
    
      [XmlElement(ElementName="canformpersona")] 
      public string CanFormPersona { get; set; } = string.Empty;
      
      [XmlElement(ElementName="modattack")] 
      public string ModAttack { get; set; } = string.Empty;
      
      [XmlElement(ElementName="modsleaze")] 
      public string ModSleaze { get; set; } = string.Empty;

      [XmlElement(ElementName="moddataprocessing")] 
      public string ModDataProcessing { get; set; } = string.Empty;

      [XmlElement(ElementName="modfirewall")] 
      public string ModFirewall { get; set; } = string.Empty;

      [XmlElement(ElementName="matrixcmbonus")] 
      public int MatrixCMBonus { get; set; }

      [XmlElement(ElementName = "attributearray")]
      public string AttributeArray { get; set; } = string.Empty;

      [XmlElement(ElementName = "modattributearray")]
      public string ModAttributeArray { get; set; } = string.Empty;
}