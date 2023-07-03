using ChummerDBRazorLibrary.Backend.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace ChummerDBRazorLibrary.Bases;

public abstract partial class RecipientViewModelBase<TMessage>: ObservableRecipient, IViewModelBase, IRecipient<TMessage> where TMessage: class
{
    protected virtual void NotifyStateChanged() => OnPropertyChanged((string?) null);
    
    public virtual async Task OnInitializedAsync()
    {
        await Loaded().ConfigureAwait(false);
    }

    [RelayCommand]
    public virtual async Task Loaded()
    {
        await Task.CompletedTask.ConfigureAwait(false);
    }

    public abstract void Receive(TMessage message);
}