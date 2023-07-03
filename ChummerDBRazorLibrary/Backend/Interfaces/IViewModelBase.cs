using System.ComponentModel;

namespace ChummerDBRazorLibrary.Backend.Interfaces;

public interface IViewModelBase : INotifyPropertyChanged
{
    Task OnInitializedAsync();
    Task Loaded();
}