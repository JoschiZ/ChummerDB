namespace ChummerDBRazorLibrary.Backend.Bases;

public interface IXmlDataModelBase<T>
{
    public Task<List<T>> GetItems();
}