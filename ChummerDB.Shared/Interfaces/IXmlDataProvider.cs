namespace ChummerDB.Shared.Interfaces;

public interface IXmlDataProvider
{
    Task<Stream> GetData(string path);
}
