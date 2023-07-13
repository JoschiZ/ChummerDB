namespace ChummerDBRazorLibrary.Backend.Interfaces;

public interface IXmlDataProvider
{
    Task<Stream> GetData(string path);
}
