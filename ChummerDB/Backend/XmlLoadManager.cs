using System.Xml;
using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.Data.xml;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDB.Backend;

public class XmlLoadManager: IXmlLoadManager
{
    private static readonly Dictionary<Type, string> FilePaths = new()
    {
        {typeof(SpellsXmlRecord), "spells.xml"},
        {typeof(BooksXmlRecord), "books.xml"}
    };

    private static Dictionary<Type, object?> XmlObjectCache { get; } = new();

    public async Task<T> GetXml<T>()
    {
        if (!XmlObjectCache.TryGetValue(typeof(T), out var value)) 
            return await LoadXmlAsync<T>();
        
        if (value is null)
        {
            throw new NullReferenceException();
        }
        return (T)value;

    }
    
    
    private static async ValueTask<T> LoadXmlAsync<T>()
    {
        using var stream = FileSystem.Current.OpenAppPackageFileAsync(FilePaths[typeof(T)]);
        
        var serializer = new XmlSerializer(typeof(T));
        using var reader = XmlReader.Create(await stream);
        var xmlObject = serializer.Deserialize(reader);

        XmlObjectCache[typeof(T)] = xmlObject ?? throw new NullReferenceException();
        
        return (T)xmlObject;
    }
}