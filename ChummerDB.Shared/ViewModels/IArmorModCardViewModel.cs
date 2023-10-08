using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.ViewModels;

public interface IArmorModCardViewModel: IViewModelBase
{
    string? DisplayArmor { get; }
    string DisplayMaxRating { get; }
    string DisplayNeededCapacity { get; }
    string? DisplayCapacity { get; }
    string DisplayAddonCategories { get; }
    ArmorMod? ArmorMod { get; set; }
}