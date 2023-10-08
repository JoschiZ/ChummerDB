
using ChummerDB.Shared.Bases;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChummerDB.Shared.ViewModels;

internal sealed partial class DialogCardViewModel: ViewModelBase, IDialogCardViewModel
{ 
    [ObservableProperty]
    private bool _open;

    [RelayCommand]
    private void Toggle()
    {
        Open = !Open;
    }
}