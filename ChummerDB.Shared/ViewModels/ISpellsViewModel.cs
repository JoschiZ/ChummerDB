using System.Collections.ObjectModel;
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.ViewModels;

public interface ISpellsViewModel: IViewModelBase
{
    public ReadOnlyObservableCollection<Spell>? Spells { get; }
}