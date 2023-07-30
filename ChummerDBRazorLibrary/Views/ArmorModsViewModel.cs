using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Models;
using ChummerDBRazorLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.Views;

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