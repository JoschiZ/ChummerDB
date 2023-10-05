using System.Xml.Serialization;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.Enums;

public enum Limit
{
    [XmlEnum("Social")]
    Social,
    [XmlEnum("Physical")]
    Physical,
    [XmlEnum("Mental")]
    Mental
}