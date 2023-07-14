using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.Enums;

namespace ChummerDBRazorLibrary.Backend.xml.Bonus;

public abstract class ResistBonusBase : BaseBonus
{
    [XmlText]
    public string Amount { get; set; } = string.Empty;
    
    public abstract string Name { get; }
}

[XmlRoot("firearmor")]
public class FireResistBonus : ResistBonusBase
{
    public override string Name { get; } = "Fire Resistance";
}

[XmlRoot("coldarmor")]
public class ColdResistBonus : ResistBonusBase
{
    public override string Name { get; } = "Cold Resistance";
}

[XmlRoot("electricityarmor")]
public class ElectricityResistBonus : ResistBonusBase
{
    public override string Name { get; } = "Electro Resistance";
}

[XmlRoot("toxincontactresist")]
public class ContactToxinResist : ResistBonusBase
{
    public override string Name { get; } = "Contact Toxin Resistance";
}

[XmlRoot("pathogencontactresist")]
public class PathogenContactResist : ResistBonusBase
{
    public override string Name { get; } = "Contact Pathogen Resistance";
}


