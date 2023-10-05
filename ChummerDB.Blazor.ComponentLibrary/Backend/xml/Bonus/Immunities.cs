using System.Xml.Serialization;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.xml.Bonus;

public abstract class Immunities: BaseBonus
{
    [XmlText]
    public string? InnerText { get; set; }

    private bool IsImmune => InnerText is null;

    public abstract string Name { get; }

    public override string DisplayString => IsImmune ? Name : string.Empty;
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
