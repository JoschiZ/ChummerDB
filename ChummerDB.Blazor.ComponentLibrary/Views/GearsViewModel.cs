using System.Collections.ObjectModel;
using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.Models;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml.Gear;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDB.Blazor.ComponentLibrary.Views;

public partial class GearsViewModel : ViewModelBase, IGearsViewModel
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