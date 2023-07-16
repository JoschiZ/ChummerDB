namespace ChummerDBRazorLibrary.Backend.Util;

public static class Util
{
    /// <summary>
    /// Convenience Method to get a int? from an string
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int? GetInt(this string s)
    {
        if (int.TryParse(s, out var outValue))
        {
            return outValue;
        }

        return null;
    }
}