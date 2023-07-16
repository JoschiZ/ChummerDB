using ChummerDBRazorLibrary.Backend.Enums;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.xml.Extensions;

public static partial class IHasAvailabilityExtensions
{
    public static int? GetAvailabilityInt(this IHasAvailability hasAvailability)
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

    public static Legality GetLegality(this IHasAvailability hasAvailability)
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