
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml.Bonus;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDB.Shared.ViewModels;

internal sealed partial class BonusCardViewModel: ViewModelBase, IBonusCardViewModel
{
    [ObservableProperty] private IEnumerable<BaseBonus>? _bonuses;

}