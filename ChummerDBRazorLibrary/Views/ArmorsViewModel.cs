using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Models;
using ChummerDBRazorLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.Views;

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