using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Views;

public interface IArmorsViewModel: IViewModelBase
{
    public ReadOnlyObservableCollection<Armor>? Armors { get; }
}