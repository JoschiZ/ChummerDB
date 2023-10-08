using ChummerDB.Shared.Bases;
using ChummerDB.Shared.Models;
using ChummerDB.Shared.xml;
using CommunityToolkit.Mvvm.ComponentModel;


namespace ChummerDB.Shared.ViewModels;

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