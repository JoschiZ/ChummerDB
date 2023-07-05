using System.Diagnostics;

namespace ChummerDBRazorLibrary.Backend.xml.Extensions;

public static class SpellExtensions
{
    public static string GetDisplayType(this Spell spell)
    {
        return spell.Type switch
        {
            "M" => "Mana",
            "P" => "Physical",
            _ => spell.Type
        };
    }

    public static string GetDisplayRange(this Spell spell)
    {
        return spell.Range
            .Replace("LOS", "Line of sight")
            .Replace("(A)", "(Area)")
            .Replace("T", "Touch");
    }

    public static string GetDisplayDuration(this Spell spell)
    {
        return spell.Duration switch
        {
            "I" => "Instantaneous",
            "S" => "Sustained",
            "P" => "Permanent",
            _ => spell.Duration
        };
    }

    public static string GetDisplayDrain(this Spell spell)
    {
        return spell.Dv.Replace("F", "[Force]");
    }
}