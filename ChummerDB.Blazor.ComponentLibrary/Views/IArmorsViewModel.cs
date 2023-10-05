using System.Collections.ObjectModel;
using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;

namespace ChummerDB.Blazor.ComponentLibrary.Views;

public interface IArmorsViewModel: IViewModelBase
{
    public ReadOnlyObservableCollection<Armor>? Armors { get; }
}