using ChummerDBRazorLibrary.Backend.Interfaces;

namespace ChummerDBRazorLibrary.Backend.Bases;

public abstract class XmlDataModelBase<T>: IXmlDataModelBase<T>
{
    protected XmlDataModelBase(IXmlLoadManager xmlLoadManager)
    {
        XmlLoadManager = xmlLoadManager;
    }

    private protected IXmlLoadManager XmlLoadManager { get; }
    
    private protected bool IsLoaded { get; set; }
    
    private protected List<T> Items { private get; set; } = new();

    private protected abstract Task<List<T>> LoadItems();

    public Task<List<T>> GetItems() => IsLoaded ? Task.FromResult(Items) : LoadItems();
}