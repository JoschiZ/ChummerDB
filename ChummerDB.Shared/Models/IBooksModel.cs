using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.Models;

public interface IBooksModel: INamedXmlDataModel<Book>
{
    public Task<Book> GetBook(string bookCode);
}
