using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml.Bonus;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.Components;

public partial class BonusCardViewModel: ViewModelBase
{
    [ObservableProperty] 
    private IEnumerable<BaseBonus> _bonuses = Enumerable.Empty<BaseBonus>();

}