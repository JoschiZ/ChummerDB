using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.xml.Extensions;

public static class IHasCostExtensions
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
}