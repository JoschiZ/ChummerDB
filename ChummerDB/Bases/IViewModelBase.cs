using System.ComponentModel;

namespace ChummerDB.ViewModels;

public interface IViewModelBase : INotifyPropertyChanged
{
    Task OnInitializedAsync();
    Task Loaded();
}