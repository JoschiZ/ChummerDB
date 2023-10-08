
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.Models;
using ChummerDB.Shared.xml;
using ChummerDB.Shared.xml.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace ChummerDB.Shared.ViewModels;

internal sealed partial class DisplaySourceViewModel: ViewModelBase, IDisplaySourceViewModel
{
    [ObservableProperty] private IHasSource? _sourceObject;
    [ObservableProperty] private Book? _book;

    public DisplaySourceViewModel(IBooksModel booksModel)
    {
        BooksModel = booksModel;
    }

    private IBooksModel BooksModel { get; }

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