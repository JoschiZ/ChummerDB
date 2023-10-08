using ChummerDB.Shared.xml.Interfaces;

namespace ChummerDB.Shared.xml.Extensions;

public static class IHasDrainExtensions
{
    public static string GetDisplayDrain(this IHasDrain hasDrain)
    {
        return hasDrain.Drain.Replace("F", "[Force]").Replace("L", "[Level]");
    }
}