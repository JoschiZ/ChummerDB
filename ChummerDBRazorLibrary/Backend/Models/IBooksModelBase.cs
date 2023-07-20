using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;

public interface IBooksModelBase: IXmlDataModelBase<Book>
{
    public Task<Book> GetBook(string bookCode);
}
