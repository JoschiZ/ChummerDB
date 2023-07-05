using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml;

[XmlRoot("chummer")]
public class BooksXmlRecord
{
    [XmlArray("books")]
    [XmlArrayItem("book")]
    public List<Book> Books { get; set; } = new List<Book>();

}