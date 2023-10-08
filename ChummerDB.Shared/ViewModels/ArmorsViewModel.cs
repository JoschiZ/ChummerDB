using System.Collections.ObjectModel;
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.Models;
using ChummerDB.Shared.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDB.Shared.ViewModels;

internal sealed partial class ArmorsViewModel : ViewModelBase, IArmorsViewModel
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