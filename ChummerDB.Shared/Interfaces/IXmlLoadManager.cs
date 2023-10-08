namespace ChummerDB.Shared.Interfaces;

public interface IXmlLoadManager
{
    public Task<T> GetXml<T>();
}