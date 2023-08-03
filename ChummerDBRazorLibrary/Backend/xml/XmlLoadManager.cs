using System.Xml;
using System.Xml.Serialization;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.Util;
using ChummerDBRazorLibrary.Backend.xml.Gear;

namespace ChummerDBRazorLibrary.Backend.xml;

public class XmlLoadManager : IXmlLoadManager
{
    private readonly IXmlDataProvider _xmlDataProvider;
    
    public static readonly Dictionary<Type, string> FilePaths = new()
    {
        {typeof(SpellsXmlRecord), "spells.xml"},
        {typeof(BooksXmlRecord), "books.xml"},
        {typeof(ComplexFormsXmlRecord), "complexforms.xml"},
        {typeof(ArmorXmlRecord), "armor.xml"},
        {typeof(GearsXmlRecord), "gear.xml"}
    };

    private static Dictionary<Type, object?> XmlObjectCache { get; } = new();

    public XmlLoadManager(IXmlDataProvider xmlDataProvider)
    {
        _xmlDataProvider = xmlDataProvider;
    }
    
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
    
    private async Task<T> LoadXmlAsync<T>()
    {
        var stream = await _xmlDataProvider.GetData(FilePaths[typeof(T)]);
        if (XmlTransformationManager.ShouldTransform<T>())
        {
           stream = XmlTransformationManager.TransformXml<T>(stream);
        }
        
        var serializer = new XmlSerializer(typeof(T));
        using var reader = XmlReader.Create(stream);
        var xmlObject = serializer.Deserialize(reader);

        XmlObjectCache[typeof(T)] = xmlObject ?? throw new NullReferenceException();
        
        return (T)xmlObject;
    }
}