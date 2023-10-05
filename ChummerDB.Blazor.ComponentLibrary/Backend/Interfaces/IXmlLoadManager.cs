namespace ChummerDB.Blazor.ComponentLibrary.Backend.Interfaces;

public interface IXmlLoadManager
{
    public Task<T> GetXml<T>();
}