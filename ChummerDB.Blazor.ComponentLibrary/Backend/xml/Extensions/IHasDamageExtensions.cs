using ChummerDB.Blazor.ComponentLibrary.Backend.xml.Interfaces;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.xml.Extensions;

public static class IHasDamageExtensions
{
    public static string GetDisplayDamage(this IHasDamage iHasDamage)
    {
        return iHasDamage.Damage switch
        {
            "S" => "Stun",
            "P" => "Physical",
            _ => iHasDamage.Damage
        };
    }
}