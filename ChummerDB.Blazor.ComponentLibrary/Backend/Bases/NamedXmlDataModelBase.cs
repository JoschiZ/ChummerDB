using ChummerDB.Blazor.ComponentLibrary.Backend.Interfaces;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml.Interfaces;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.Bases;

public abstract class NamedXmlDataModelBase<T>: XmlDataModelBase<T>, INamedXmlDataModel<T> where T: IHasName
{
    protected NamedXmlDataModelBase(IXmlLoadManager xmlLoadManager) : base(xmlLoadManager)
    {
    }

    private readonly Dictionary<string, T?> ByNameCache = new();


    public virtual async Task<T?> GetItemByName(string name)
    {
        if (ByNameCache.TryGetValue(name, out var cachedItem))
        {
            return cachedItem;
        }

        var items = await GetItems();

        var item = items.Find(item => item.Name == name);

        ByNameCache.TryAdd(name, item);
        
        return item;
    }
}