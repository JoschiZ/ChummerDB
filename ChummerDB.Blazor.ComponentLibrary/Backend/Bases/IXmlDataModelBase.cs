namespace ChummerDB.Blazor.ComponentLibrary.Backend.Bases;

public interface IXmlDataModelBase<T>
{
    public Task<List<T>> GetItems();
}