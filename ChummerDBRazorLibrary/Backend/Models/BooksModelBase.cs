using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;

public class BooksModelBase: XmlDataModelBase<Book>, IBooksModelBase
{
    private Dictionary<string, Book> BookCache { get; } = new();
    
    private protected override async Task<List<Book>> LoadItems()
    {
        var books = await XmlLoadManager.GetXml<BooksXmlRecord>();
        Items = books.Books;
        IsLoaded = true;
        return Items;
    }

    public async Task<Book> GetBook(string bookCode)
    {
        if(BookCache.TryGetValue(bookCode, out var searchedBook))
        {
            return searchedBook;
        }

        var books = await GetItems();
        searchedBook = books.Find(book => book.Code == bookCode) ?? new Book();

        BookCache.TryAdd(bookCode, searchedBook);
        return searchedBook;
    }

    public BooksModelBase(IXmlLoadManager xmlLoadManager) : base(xmlLoadManager)
    {
    }
}