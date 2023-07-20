using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Models;
using ChummerDBRazorLibrary.Backend.xml;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChummerDBRazorLibrary.Components;

public partial class DisplaySourceViewModel: ViewModelBase
{
    [ObservableProperty] private IHasSource? _sourceObject;
    [ObservableProperty] private Book? _book;

    public DisplaySourceViewModel(IBooksModelBase booksModelBase)
    {
        BooksModelBase = booksModelBase;
    }

    private IBooksModelBase BooksModelBase { get; }

    public override async Task OnParametersSetAsync()
    {
        if (SourceObject is not null)
        {
            Book = await BooksModelBase.GetBook(SourceObject.Source);
        }
    }
    
    [RelayCommand]
    private static void OpenSourceFile()
    {
        throw new NotImplementedException();
    }

}