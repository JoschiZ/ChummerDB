using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml.Bonus;

namespace ChummerDB.Blazor.ComponentLibrary.Components.Cards;

public interface IBonusCardViewModel : IViewModelBase
{
    IEnumerable<BaseBonus>? Bonuses { get; }
}