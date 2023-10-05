using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.Models;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDB.Blazor.ComponentLibrary.Components.Cards;

public partial class ArmorCardViewModel: ViewModelBase, IArmorCardViewModel
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
        return await _armorModsModel.GetItemByName(name);
    }
}