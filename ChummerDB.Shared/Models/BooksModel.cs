using ChummerDB.Shared.Bases;
using ChummerDB.Shared.Interfaces;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.Models;

public class BooksModel: NamedXmlDataModelBase<Book>, IBooksModel
{
    private Dictionary<string, Book> BookCache { get; } = new();
    
    private protected override async Task<List<Book>> LoadItems()
    {
        var books = await XmlLoadManager.GetXml<BooksXmlRecord>();
        Items = books.Books;
        IsLoaded = true;
        return await GetItems();
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

    public BooksModel(IXmlLoadManager xmlLoadManager) : base(xmlLoadManager)
    {
    }
}