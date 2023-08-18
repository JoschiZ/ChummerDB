using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Models;
using ChummerDBRazorLibrary.Backend.xml.Gear;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.Views;

public partial class GearsViewModel : ViewModelBase
{
    private readonly GearsModel _model;

    [ObservableProperty]
    private ReadOnlyObservableCollection<Gear>? items;

    public GearsViewModel(GearsModel model)
    {
        _model = model;
    }

    public override async Task Loaded()
    {
        var itemsList = await _model.GetItems();
        Items = new ReadOnlyObservableCollection<Gear>(new ObservableCollection<Gear>(itemsList));
    }
    
}