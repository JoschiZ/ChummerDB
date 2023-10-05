using System.Collections.ObjectModel;
using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.Models;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDB.Blazor.ComponentLibrary.Views;

public partial class ArmorModsViewModel : ViewModelBase, IArmorModsViewModel
{
    [ObservableProperty] private ReadOnlyObservableCollection<ArmorMod>? _items;

    public ArmorModsViewModel(IArmorModsModel model)
    {
        Model = model;
    }

    private IArmorModsModel Model { get; }

    public override async Task Loaded()
    {
        var items = await Model.GetItems();
        Items = new ReadOnlyObservableCollection<ArmorMod>(new ObservableCollection<ArmorMod>(items));
    }
}