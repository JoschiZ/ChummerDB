namespace ChummerDB.Shared.xml.Extensions;

public static class ArmorExtensions
{
    public static string GetDisplayString(this Armor armor)
    {
        if (armor.StackingArmor == 0)
        {
            return armor.ArmorClass;
        }
        return $"{armor.ArmorClass} (+{armor.StackingArmor})";
    }
}