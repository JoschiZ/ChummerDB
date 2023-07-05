using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.Models.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;

public class BooksModel: IBooksModel
{
    public BooksModel(IXmlLoadManager xmlLoadManager)
    {
        XmlLoadManager = xmlLoadManager;
    }

    private List<Book> Books { get; set; } = new();

    private Dictionary<string, Book> BookCache { get; } = new Dictionary<string, Book>();
    
    public Task<List<Book>> GetBooks() => IsLoaded ? Task.FromResult(Books) : LoadBooks();
    
    private IXmlLoadManager XmlLoadManager { get; }

    private async Task<List<Book>> LoadBooks()
    {
        var books = await XmlLoadManager.GetXml<BooksXmlRecord>();
        Books = books.Books;
        IsLoaded = true;
        return Books;
    }

    private bool IsLoaded { get; set; }



    public async Task<Book> GetBook(string bookCode)
    {
        if(BookCache.TryGetValue(bookCode, out var searchedBook))
        {
            return searchedBook;
        }

        var books = await GetBooks();
        searchedBook = books.Find(book => book.Code == bookCode) ?? new Book();

        BookCache.TryAdd(bookCode, searchedBook);
        return searchedBook;
    }
}