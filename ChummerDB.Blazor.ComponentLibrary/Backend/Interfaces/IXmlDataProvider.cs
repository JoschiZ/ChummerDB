namespace ChummerDB.Blazor.ComponentLibrary.Backend.Interfaces;

public interface IXmlDataProvider
{
    Task<Stream> GetData(string path);
}
