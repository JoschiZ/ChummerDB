namespace ChummerDB.Shared.Bases;

public interface IXmlDataModelBase<T>
{
    public Task<List<T>> GetItems();
}