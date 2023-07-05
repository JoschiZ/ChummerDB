using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.xml.Extensions;

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