using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.Interfaces;

public interface INamedXmlDataModel<T>: IXmlDataModelBase<T> where T: IHasName
{
    public Task<T?> GetItemByName(string name);
}