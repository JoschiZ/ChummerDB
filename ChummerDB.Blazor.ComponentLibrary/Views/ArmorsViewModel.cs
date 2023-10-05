using System.Collections.ObjectModel;
using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.Models;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDB.Blazor.ComponentLibrary.Views;

public partial class ArmorsViewModel : ViewModelBase, IArmorsViewModel
{
    public ArmorsViewModel(IArmorsModel armorsModel)
    {
        ArmorsModel = armorsModel;
    }

    private IArmorsModel ArmorsModel { get; }

    [ObservableProperty] private ReadOnlyObservableCollection<Armor>? _armors;

    public override async Task Loaded()
    {
        var armors = await ArmorsModel.GetItems();
        Armors = new ReadOnlyObservableCollection<Armor>(new ObservableCollection<Armor>(armors));
    }
}