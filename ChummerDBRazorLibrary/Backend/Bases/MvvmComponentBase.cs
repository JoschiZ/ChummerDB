using System.Diagnostics.CodeAnalysis;
using ChummerDBRazorLibrary.Backend.Interfaces;
using Microsoft.AspNetCore.Components;

namespace ChummerDBRazorLibrary.Backend.Bases;

public abstract class MvvmComponentBase<TViewModel>: ComponentBase where TViewModel : IViewModelBase
{
    [Inject]
    [NotNull]
#pragma warning disable CS8618
    protected TViewModel ViewModel { get; set; }
#pragma warning restore CS8618

    protected override void OnInitialized()
    {
        ViewModel.PropertyChanged += (_, _) => StateHasChanged();
        base.OnInitialized();
    }

    protected override Task OnInitializedAsync()
    {
        return ViewModel.OnInitializedAsync();
    }
}