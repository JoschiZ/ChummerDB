using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Models;
using ChummerDBRazorLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.Components.Cards;

public partial class ArmorCardViewModel: ViewModelBase
{
    [ObservableProperty] 
    private Armor? _armor;

    private readonly IArmorModsModel _armorModsModel;

    public ArmorCardViewModel(IArmorModsModel armorModsModel)
    {
        _armorModsModel = armorModsModel;
    }
    
    public async Task<ArmorMod?> GetArmorMod(string name)
    {
        return await _armorModsModel.GetArmorMod(name);
    }
}