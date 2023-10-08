using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml.Bonus;

namespace ChummerDB.Shared.ViewModels;

public interface IBonusCardViewModel : IViewModelBase
{
    IEnumerable<BaseBonus>? Bonuses { get; set; }
}