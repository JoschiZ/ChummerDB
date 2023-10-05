using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;

namespace ChummerDB.Blazor.ComponentLibrary.Components.Cards;

public interface IDialogCardViewModel: IViewModelBase
{
    /// <inheritdoc cref="DialogCardViewModel._open"/>
    bool Open { get; set; }

    /// <summary>Gets an <see cref="global::CommunityToolkit.Mvvm.Input.IRelayCommand"/> instance wrapping <see cref="DialogCardViewModel.Toggle"/>.</summary>
    CommunityToolkit.Mvvm.Input.IRelayCommand ToggleCommand { get; }
}