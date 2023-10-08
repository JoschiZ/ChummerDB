using ChummerDB.Shared.Interfaces;

namespace ChummerDB.Backend;

public class XmlDataProvider: IXmlDataProvider
{
    public Task<Stream> GetData(string path)
    {
        return FileSystem.Current.OpenAppPackageFileAsync(path);
    }
}