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

    /// <summary>
    /// Don't use this directly! Call GetItems() instead!
    /// </summary>
    [Obsolete("This is not actually obsolete, you should just use GetItems() instead")]
    private protected List<T> Items { get; set; } = new();

    private protected abstract Task<List<T>> LoadItems();

#pragma warning disable CS0618 // Type or member is obsolete
    public Task<List<T>> GetItems() => IsLoaded ? Task.FromResult(Items) : LoadItems();
#pragma warning restore CS0618 // Type or member is obsolete
}