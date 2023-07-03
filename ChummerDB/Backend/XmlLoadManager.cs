using System.Xml;
using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.Data.xml;
using ChummerDBRazorLibrary.Interfaces;

namespace ChummerDB.Backend;

public class XmlLoadManager: IXmlLoadManager
{
    public static readonly Dictionary<Type, string> FilePaths = new()
    {
        {typeof(SpellsXmlRecord), "spells.xml"},
    };

    private static Dictionary<Type, object> XmlObjectCache { get; } = new();

    public async Task<T> GetXml<T>()
    {
        if (XmlObjectCache.ContainsKey(typeof(T)))
        {
            return (T)XmlObjectCache[typeof(T)];
        }
        
        return await LoadXmlAsync<T>(FilePaths[typeof(T)]);
    }
    
    
    private static async ValueTask<T> LoadXmlAsync<T>(string path)
    {
        using var stream = FileSystem.Current.OpenAppPackageFileAsync("spells.xml");
        
        var serializer = new XmlSerializer(typeof(T));
        using var reader = XmlReader.Create(await stream);
        var xmlObject = serializer.Deserialize(reader);
        if (xmlObject is null)
        {
            throw new NullReferenceException();
        }


        return (T)xmlObject;
    }
}