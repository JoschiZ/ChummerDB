using System.Xml;
using System.Xml.Serialization;
using ChummerDB.Data.xml;

namespace ChummerDB.Data;

public class XmlLoadManager: IXmlLoadManager
{
    public static readonly Dictionary<Type, string> FilePaths = new()
    {
        {typeof(SpellsXml), "spells.xml"},
    };

    private static Dictionary<Type, object> XmlObjectCache { get; } = new();

    public async Task<T> GetXml<T>(string path)
    {
        if (XmlObjectCache.ContainsKey(typeof(T)))
        {
            return (T)XmlObjectCache[typeof(T)];
        }

        if (typeof(T) is IHasDependency hasDependency)
        {
                        
        }
        
        return await LoadXmlAsync<T>(path);
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

public interface IXmlLoadManager
{
    public Task<T> GetXml<T>(string path);
}