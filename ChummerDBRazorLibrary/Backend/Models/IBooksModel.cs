using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;

public interface IBooksModel: INamedXmlDataModel<Book>
{
    public Task<Book> GetBook(string bookCode);
}
