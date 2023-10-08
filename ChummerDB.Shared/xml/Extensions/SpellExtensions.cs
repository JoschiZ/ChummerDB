namespace ChummerDB.Shared.xml.Extensions;

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
}