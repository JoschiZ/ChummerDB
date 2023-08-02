using System.Diagnostics.CodeAnalysis;
using System.Xml;
using System.Xml.Serialization;

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

    private static readonly Dictionary<string, XmlSerializer> _xmlSerializerCache = new();
    
    public static bool TryDeserialize<T>(this XmlReader reader, [NotNullWhen(returnValue: true)] out T? item, XmlRootAttribute? xmlRootAttribute = null)
    {
        item = default;
        if (!_xmlSerializerCache.TryGetValue(reader.Name, out var serializer))
        {
            serializer = xmlRootAttribute is not null ? new XmlSerializer(typeof(T), xmlRootAttribute) : new XmlSerializer(typeof(T));
            _xmlSerializerCache.TryAdd(reader.Name, serializer);
        }
        
        var deserializedItem = serializer.Deserialize(reader);

        if (deserializedItem is null)
        {
            return false;
        }

        item = (T) deserializedItem;
        return true;
    }

    public static void ReadToEndElement(this XmlReader reader, string name)
    {
        if (reader.IsEmptyElement) 
            return;
        
        while (reader.NodeType != XmlNodeType.EndElement && reader.Name != name)
        {
            reader.Read();
        }
    }
}