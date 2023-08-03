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
    private ReadOnlyObservableCollection<Gear>? _gears;

    public GearsViewModel(GearsModel model)
    {
        _model = model;
    }

    public override async Task Loaded()
    {
        var items = await _model.GetItems();
        Gears = new ReadOnlyObservableCollection<Gear>(new ObservableCollection<Gear>(items));
    }
    
}