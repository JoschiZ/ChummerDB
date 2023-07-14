using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml.Bonus;

public abstract class Immunities: BaseBonus
{
    [XmlText]
    public string? InnerText { get; set; }

    public bool IsImmune => InnerText is null;

    public abstract string Name { get; }
}

[XmlRoot("toxininhalationimmune")]
public class InhalationToxinImmunityBonus: Immunities
{
    public override string Name { get; } = "Inhalation Toxin Immunity";
}

[XmlRoot("toxincontactimmune")]
public class ContactToxinImmunityBonus: Immunities
{
    public override string Name { get; } = "Contact Toxin Immunity";
}

[XmlRoot("pathogencontactimmune")]
public class ContactPathogenImmunityBonus: Immunities
{
    public override string Name { get; } = "Contact Pathogen Immunity";
}

[XmlRoot("pathogeninhalationimmune")]
public class InhalationPathogenImmunityBonus: Immunities
{
    public override string Name { get; } = "Inhalation Pathogen Immunity";
}
