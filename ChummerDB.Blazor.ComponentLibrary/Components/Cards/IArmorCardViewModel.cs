using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;

namespace ChummerDB.Blazor.ComponentLibrary.Components.Cards;

public interface IArmorCardViewModel: IViewModelBase
{
    public Armor? Armor { get; set; }
}