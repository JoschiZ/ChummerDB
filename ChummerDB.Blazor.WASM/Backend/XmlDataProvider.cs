using System.IO.Compression;
using System.Text;
using ChummerDB.Blazor.ComponentLibrary.Backend.Interfaces;

namespace ChummerDB.Blazor.WASM.Backend;

public class XmlDataProvider: IXmlDataProvider
{
    public XmlDataProvider(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    private HttpClient HttpClient { get; }
    

    public async Task<Stream> GetData(string path)
    {
        var stream = HttpClient.GetStreamAsync("data/" + path + ".zz");

        var ms = new MemoryStream();
        //Sadly Brotli is not supported on browsers, could have saved some of those sweet sweet kB download size :/
        await using var decompressor = new DeflateStream(await stream, CompressionMode.Decompress);
        await decompressor.CopyToAsync(ms);
        ms.Position = 0;
        return ms;
    }
}