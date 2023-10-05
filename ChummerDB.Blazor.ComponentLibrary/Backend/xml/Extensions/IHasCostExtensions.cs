using ChummerDB.Blazor.ComponentLibrary.Backend.Enums;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml.Interfaces;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.xml.Extensions;

public static partial class IHasCostExtensions
{
    public static string GetCostString(this IHasCost hasCost)
    {
        return hasCost.Cost + "¥";
    }

    public static int? GetIntCost(this IHasCost hasCost)
    {
        if (int.TryParse(hasCost.Cost, out var cost))
        {
            return cost;
        }

        return null;
    }
    
    public static int? GetAvailabilityInt(this IHasCost hasAvailability)
    {
        var stringValue = hasAvailability.Availability;
    
        // Remove non-digits
        stringValue = RemoveNonDigits().Replace(stringValue, "");

        if (int.TryParse(stringValue, out var result))
        {
            return result;
        }

        // Return null if unable to parse
        return null;
    }

    public static Legality GetLegality(this IHasCost hasAvailability)
    {
        if (hasAvailability.Availability.EndsWith("R"))
        {
            return Legality.Restricted;
        }

        if (hasAvailability.Availability.EndsWith("F"))
        {
            return Legality.Forbidden;
        }

        return Legality.Legal;
    }

    [System.Text.RegularExpressions.GeneratedRegex("[^\\d]")]
    private static partial System.Text.RegularExpressions.Regex RemoveNonDigits();
}