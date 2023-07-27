using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Models;
using ChummerDBRazorLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.Components;

public partial class ArmorModViewModel: ViewModelBase
{
    [ObservableProperty]
    private ArmorMod? _armorMod;
}