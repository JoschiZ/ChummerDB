using System.Collections.ObjectModel;
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.Models;
using ChummerDB.Shared.xml.Gear;
using CommunityToolkit.Mvvm.ComponentModel;


namespace ChummerDB.Shared.ViewModels;

internal sealed partial class GearsViewModel : ViewModelBase, IGearsViewModel
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