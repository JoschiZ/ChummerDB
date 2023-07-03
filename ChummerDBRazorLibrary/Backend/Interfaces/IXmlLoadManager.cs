namespace ChummerDBRazorLibrary.Interfaces;

public interface IXmlLoadManager
{
    public Task<T> GetXml<T>();
}