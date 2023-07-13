using System.Reflection;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;
using NSubstitute;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace RazorLibraryTests.xml;

public class XmlLoadManagerTests
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly IXmlDataProvider _xmlDataProvider;
    private readonly XmlLoadManager _xmlLoadManager;

    public XmlLoadManagerTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _xmlDataProvider = Substitute.For<IXmlDataProvider>();
        _xmlLoadManager = new XmlLoadManager(_xmlDataProvider);
    }

    public static IEnumerable<object[]> GetXmlStreams()
    {
        var allData = new List<object[]>();

        foreach (var (type, path) in XmlLoadManager.FilePaths)
        {
            var filePath = Path.GetRelativePath(Directory.GetCurrentDirectory(), "data/" + path);

            if (!File.Exists(filePath))
            {
                throw new ArgumentException($"Could not find file at path: {filePath}");
            }

            var fileData = File.ReadAllText(filePath);
            allData.Add(new object[] {type, path, fileData});
        }

        return allData;
    }

    // Test if the correct XML file is loaded and deserialized
    [Theory]
    [MemberData(nameof(GetXmlStreams))]
    public async Task GetXml_ShouldLoadCorrectXml(Type T, string filePath, string xmlString)
    {
        using var stream = new MemoryStream();
        await using var writer = new StreamWriter(stream);
        await writer.WriteAsync(xmlString);
        await writer.FlushAsync();
        stream.Position = 0;

        _xmlDataProvider.GetData(filePath).Returns(stream);
        
        // Use reflections to call generic method
        var method = typeof(XmlLoadManager).GetMethod("GetXml");
        if (method is null)
        {
            throw new InvalidOperationException("Could not get GetXml form XmlLoadManager");
        }
        var generic = method.MakeGenericMethod(T);
        
        // Here we use 'dynamic' to bypass compile-time type checking.
        dynamic resultTask = generic.Invoke(_xmlLoadManager, null) ?? throw new XunitException("Invocation failed");
        
        var result = await resultTask;
        
        Assert.NotNull(result);
    }
}