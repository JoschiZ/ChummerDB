using System.Collections.ObjectModel;
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.ViewModels;

public interface IArmorsViewModel: IViewModelBase
{
    public ReadOnlyObservableCollection<Armor>? Armors { get; }
}