using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChummerDB.Blazor.ComponentLibrary.Components.Cards;

public partial class DialogCardViewModel: ViewModelBase, IDialogCardViewModel
{
    [ObservableProperty]
    private bool _open;

    [RelayCommand]
    private void Toggle()
    {
        Open = !Open;
    }
}