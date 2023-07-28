using ChummerDBRazorLibrary.Backend.Bases;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChummerDBRazorLibrary.Components.Cards;

public partial class PopoverCardViewModel: ViewModelBase
{
    [ObservableProperty]
    private bool _open;

    [RelayCommand]
    private void Toggle()
    {
        Open = !Open;
    }
}