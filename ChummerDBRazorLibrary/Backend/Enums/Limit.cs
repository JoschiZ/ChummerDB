using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.Enums;

public enum Limit
{
    [XmlEnum("Social")]
    Social,
    [XmlEnum("Physical")]
    Physical,
    [XmlEnum("Mental")]
    Mental
}