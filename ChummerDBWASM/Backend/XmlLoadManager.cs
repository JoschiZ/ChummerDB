using System.Xml;
using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.Data.xml;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBWASM.Backend;

public class XmlLoadManager: IXmlLoadManager
{
    private HttpClient HttpClient { get; set; }
    
    private static readonly Dictionary<Type, string> FilePaths = new()
    {
        {typeof(SpellsXmlRecord), "spells.xml"},
        {typeof(BooksXmlRecord), "books.xml"}
    };

    public XmlLoadManager(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

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
    
    
    private async ValueTask<T> LoadXmlAsync<T>()
    {
        var stream = HttpClient.GetStreamAsync("data/" + FilePaths[typeof(T)]);
        
        var serializer = new XmlSerializer(typeof(T));
        using var reader = XmlReader.Create(await stream);
        var xmlObject = serializer.Deserialize(reader);

        XmlObjectCache[typeof(T)] = xmlObject ?? throw new NullReferenceException();
        
        return (T)xmlObject;
    }
}