using ChummerDB.Blazor.ComponentLibrary.Backend.xml.Interfaces;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.xml.Extensions;

public static class IHasDrainExtensions
{
    public static string GetDisplayDrain(this IHasDrain hasDrain)
    {
        return hasDrain.Drain.Replace("F", "[Force]").Replace("L", "[Level]");
    }
}