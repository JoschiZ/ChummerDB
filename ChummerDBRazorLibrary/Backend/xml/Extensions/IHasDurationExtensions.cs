using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.xml.Extensions;

public static class IHasDurationExtensions
{
    public static string GetDisplayDuration(this IHasDuration iDuration)
    {
        return iDuration.Duration switch
        {
            "I" => "Instantaneous",
            "S" => "Sustained",
            "P" => "Permanent",
            "E" => "Extended Test",
            _ => iDuration.Duration
        };
    }
}