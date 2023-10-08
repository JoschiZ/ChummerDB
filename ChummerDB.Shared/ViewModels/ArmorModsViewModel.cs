using System.Collections.ObjectModel;
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.Models;
using ChummerDB.Shared.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDB.Shared.ViewModels;

internal sealed partial class ArmorModsViewModel : ViewModelBase, IArmorModsViewModel
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