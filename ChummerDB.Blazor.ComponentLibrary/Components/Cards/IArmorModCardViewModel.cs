using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;

namespace ChummerDB.Blazor.ComponentLibrary.Components.Cards;

public interface IArmorModCardViewModel: IViewModelBase
{
    string? DisplayArmor { get; }
    string DisplayMaxRating { get; }
    string DisplayNeededCapacity { get; }
    string? DisplayCapacity { get; }
    string DisplayAddonCategories { get; }
    Backend.xml.ArmorMod? ArmorMod { get; set; }
}