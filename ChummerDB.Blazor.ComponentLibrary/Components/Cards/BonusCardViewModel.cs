using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml.Bonus;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDB.Blazor.ComponentLibrary.Components.Cards;

public partial class BonusCardViewModel: ViewModelBase, IBonusCardViewModel
{
    [ObservableProperty] private IEnumerable<BaseBonus>? _bonuses;

}