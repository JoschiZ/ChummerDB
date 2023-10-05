using ChummerDB.Blazor.ComponentLibrary.Backend.Interfaces;
using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.Models;

public interface IBooksModel: INamedXmlDataModel<Book>
{
    public Task<Book> GetBook(string bookCode);
}
