using System.Xml.Serialization;

namespace ChummerDB.Shared.Enums;

public enum Limit
{
    [XmlEnum("Social")]
    Social,
    [XmlEnum("Physical")]
    Physical,
    [XmlEnum("Mental")]
    Mental
}