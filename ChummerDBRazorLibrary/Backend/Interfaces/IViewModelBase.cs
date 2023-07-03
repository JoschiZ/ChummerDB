using System.ComponentModel;

namespace ChummerDBRazorLibrary.Interfaces;

public interface IViewModelBase : INotifyPropertyChanged
{
    Task OnInitializedAsync();
    Task Loaded();
}