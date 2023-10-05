using ChummerDB.Blazor.ComponentLibrary.Backend.xml.Interfaces;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.Bases;

public interface INamedXmlDataModel<T>: IXmlDataModelBase<T> where T: IHasName
{
    public Task<T?> GetItemByName(string name);
}
