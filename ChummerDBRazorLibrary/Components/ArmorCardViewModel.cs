using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.Components;

public partial class ArmorCardViewModel: ViewModelBase
{
    [ObservableProperty] 
    private Armor? _armor;
}