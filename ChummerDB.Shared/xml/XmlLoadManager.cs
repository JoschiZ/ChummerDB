using System.Xml;
using System.Xml.Serialization;
using ChummerDB.Shared.Interfaces;
using ChummerDB.Shared.Util;
using ChummerDB.Shared.xml.Gear;
using Microsoft.Extensions.Logging;

namespace ChummerDB.Shared.xml;

public class XmlLoadManager : IXmlLoadManager
{
    private readonly IXmlDataProvider _xmlDataProvider;
    private readonly ILogger<XmlLoadManager> _logger;
    
    public static readonly Dictionary<Type, string> FilePaths = new()
    {
        {typeof(SpellsXmlRecord), "spells.xml"},
        {typeof(BooksXmlRecord), "books.xml"},
        {typeof(ComplexFormsXmlRecord), "complexforms.xml"},
        {typeof(ArmorXmlRecord), "armor.xml"},
        {typeof(GearsXmlRecord), "gear.xml"}
    };

    private static Dictionary<Type, object?> XmlObjectCache { get; } = new();

    public XmlLoadManager(IXmlDataProvider xmlDataProvider, ILogger<XmlLoadManager> logger)
    {
        _xmlDataProvider = xmlDataProvider;
        _logger = logger;
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
        _logger.LogTrace("Start Loading of {Type}", nameof(T));
        var stream = await _xmlDataProvider.GetData(FilePaths[typeof(T)]);
        if (XmlTransformationManager.ShouldTransform<T>())
        {
            _logger.LogTrace("Transforming XML of {Type}", nameof(T));
           stream = XmlTransformationManager.TransformXml<T>(stream);
        }
        
        var serializer = new XmlSerializer(typeof(T));
        using var reader = XmlReader.Create(stream);
        var xmlObject = serializer.Deserialize(reader);

        XmlObjectCache[typeof(T)] = xmlObject ?? throw new NullReferenceException();
        
        return (T)xmlObject;
    }
}