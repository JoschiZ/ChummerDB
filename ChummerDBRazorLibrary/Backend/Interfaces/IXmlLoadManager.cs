namespace ChummerDBRazorLibrary.Backend.Interfaces;

public interface IXmlLoadManager
{
    public Task<T> GetXml<T>();
}