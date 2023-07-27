using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml.Bonus;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.Components.Cards;

public partial class BonusCardViewModel: ViewModelBase
{
    [ObservableProperty] private IEnumerable<BaseBonus>? _bonuses;

}