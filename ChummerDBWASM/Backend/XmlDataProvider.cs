using ChummerDBRazorLibrary.Backend.Interfaces;

namespace ChummerDBWASM.Backend;

public class XmlDataProvider: IXmlDataProvider
{
    public XmlDataProvider(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    private HttpClient HttpClient { get; set; }
    

    public Task<Stream> GetData(string path)
    {
        return HttpClient.GetStreamAsync("data/" + path);
    }
}