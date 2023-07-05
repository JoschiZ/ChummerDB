using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Models;
using ChummerDBRazorLibrary.Backend.Models.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChummerDBRazorLibrary.Backend.ViewModels;

public partial class DisplaySourceViewModel: ViewModelBase
{
    [ObservableProperty] private IHasSource? _sourceObject;
    [ObservableProperty] private Book? _book;

    public DisplaySourceViewModel(IBooksModel booksModel)
    {
        BooksModel = booksModel;
    }

    private IBooksModel BooksModel { get; set; }

    public override async Task OnParametersSetAsync()
    {
        if (SourceObject is not null)
        {
            Book = await BooksModel.GetBook(SourceObject.Source);
        }
    }
    
    [RelayCommand]
    private static void OpenSourceFile()
    {
        throw new NotImplementedException();
    }

}