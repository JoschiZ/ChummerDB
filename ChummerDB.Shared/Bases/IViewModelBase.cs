using System.ComponentModel;

namespace ChummerDB.Shared.Bases;

public interface IViewModelBase : INotifyPropertyChanged
{
    public Task OnInitializedAsync();
    public Task Loaded();
    public Task OnParametersSetAsync();

    public void OnParametersSet();
}