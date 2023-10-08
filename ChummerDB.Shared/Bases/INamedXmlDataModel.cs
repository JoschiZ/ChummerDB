using ChummerDB.Shared.xml.Interfaces;

namespace ChummerDB.Shared.Bases;

public interface INamedXmlDataModel<T>: IXmlDataModelBase<T> where T: IHasName
{
    public Task<T?> GetItemByName(string name);
}
