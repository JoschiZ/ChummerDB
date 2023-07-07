using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;

public interface IBooksModel
{
    public Task<List<Book>> GetBooks();

    public Task<Book> GetBook(string bookCode);
}
