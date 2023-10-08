
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;
using CommunityToolkit.Mvvm.ComponentModel;


namespace ChummerDB.Shared.ViewModels;

public partial class ArmorModCardViewModel: ViewModelBase, IArmorModCardViewModel
{
    [ObservableProperty]
    private ArmorMod? _armorMod;
    
    public string? DisplayArmor => ArmorMod?.Armor != 0 ? ArmorMod?.Armor.ToString() : string.Empty;
 
    public string DisplayMaxRating => ArmorMod?.MaxRating > 0 ? ArmorMod.MaxRating.ToString() : string.Empty;

    public string DisplayNeededCapacity => ArmorMod != null && ArmorMod.NeededCapacity != "[0]" ? ArmorMod.NeededCapacity : string.Empty;
    
    public string? DisplayCapacity => ArmorMod?.Capacity != 0 ? ArmorMod?.Capacity.ToString() : string.Empty;

    public string DisplayAddonCategories => ArmorMod?.AddonCategory is not null ? string.Join(",", ArmorMod.AddonCategory): string.Empty;
}