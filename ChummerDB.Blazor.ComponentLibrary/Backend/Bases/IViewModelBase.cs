using System.ComponentModel;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.Bases;

public interface IViewModelBase : INotifyPropertyChanged
{
    public Task OnInitializedAsync();
    public Task Loaded();
    public Task OnParametersSetAsync();

    public void OnParametersSet();
}